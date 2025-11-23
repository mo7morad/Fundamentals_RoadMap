using System.Collections.Concurrent;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// SIMULATED DATABASE
// In a real app, this would be SQL Server, Postgres, or Redis.
builder.Services.AddSingleton<IdempotencyStore>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// --- THE ENDPOINT ---
app.MapPost("/api/payments", async (
    [FromHeader(Name = "Idempotency-Key")] string idempotencyKey, 
    [FromBody] PaymentRequest request, 
    IdempotencyStore store) =>
{
    // 1. Validate Idempotency Key (Step 4: Error Handling)
    if (string.IsNullOrWhiteSpace(idempotencyKey))
    {
        return Results.BadRequest(new { error = "Idempotency-Key header is required." });
    }

    // 2. Check if request already exists (Step 3: Storage Logic)
    if (store.TryGet(idempotencyKey, out var existingRecord))
    {
        // If the status is completed, return the STORED response (Idempotency)
        if (existingRecord.Status == processingStatus.Completed)
        {
            return Results.Ok(existingRecord.StoredResponse);
        }
        
        // If it is currently pending (concurrent request), or failed, handle accordingly.
        return Results.Conflict(new { error = "Payment is already being processed or has failed." });
    }

    // 3. Simulate Payment Processing (Step 2: Use Case)
    // We "lock" this key by adding it as 'Pending' immediately to handle concurrency.
    if (!store.TryAdd(idempotencyKey, processingStatus.Pending))
    {
        return Results.Conflict(new { error = "Concurrent request detected." });
    }

    try
    {
        // SIMULATE WORK (e.g., calling Stripe/PayPal)
        await Task.Delay(500); 

        // Create the success response
        var response = new PaymentResponse(
            PaymentId: Guid.NewGuid().ToString(),
            Status: "Success",
            Message: $"Processed payment of {request.Amount} {request.Currency}"
        );

        // 4. Update Store with Success (Step 3: Store response)
        store.UpdateToCompleted(idempotencyKey, response);

        return Results.Ok(response);
    }
    catch (Exception ex)
    {
        // If processing fails, remove the key or mark as failed so client can retry
        store.MarkAsFailed(idempotencyKey);
        return Results.Problem("Payment processing failed.");
    }
})
.WithName("ProcessPayment")
.WithOpenApi();

app.Run();

// --- DATA MODELS ---

// The Request Body
public record PaymentRequest(decimal Amount, string Currency, string FromAccount);

// The Response Body
public record PaymentResponse(string PaymentId, string Status, string Message);

// Enum for our database status
public enum processingStatus { Pending, Completed, Failed }

// The Database Record (Simulating the table schema from the article)
public class IdempotencyRecord
{
    public string IdempotencyKey { get; set; }
    public processingStatus Status { get; set; }
    public PaymentResponse? StoredResponse { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

// --- SIMULATED DATABASE SERVICE ---
public class IdempotencyStore
{
    // ConcurrentDictionary handles the "Locking Mechanism" mentioned in Step 4
    private readonly ConcurrentDictionary<string, IdempotencyRecord> _db = new();

    public bool TryGet(string key, out IdempotencyRecord record)
    {
        return _db.TryGetValue(key, out record);
    }

    public bool TryAdd(string key, processingStatus status)
    {
        return _db.TryAdd(key, new IdempotencyRecord { IdempotencyKey = key, Status = status });
    }

    public void UpdateToCompleted(string key, PaymentResponse response)
    {
        if (_db.TryGetValue(key, out var record))
        {
            record.Status = processingStatus.Completed;
            record.StoredResponse = response;
        }
    }

    public void MarkAsFailed(string key)
    {
        if (_db.TryGetValue(key, out var record))
        {
            record.Status = processingStatus.Failed;
        }
    }
}