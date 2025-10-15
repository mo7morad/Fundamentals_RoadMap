using System;

public class PaymentService
{
    private IPaymentProcessor _paymentProcessor;

    public PaymentService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentProcessor.Process(amount);
    }
}

public interface IPaymentProcessor
{
    void Process(decimal amount);
}

public class PayPalPaymentProcessor : IPaymentProcessor
{
    // Method to process PayPal payment
    public void Process(decimal amount)
    {
        Console.WriteLine($"\nProcessing PayPal payment of {amount:C}");
    }
}

public class CreditCardPaymentProcessor : IPaymentProcessor
{
    // Method to process Credit Card payment
    public void Process(decimal amount)
    {
        Console.WriteLine($"\nProcessing Credit Card payment of {amount:C}");
    }
}

public class BankTransferPaymentProcessor : IPaymentProcessor
{
    // Method to process Bank Transfer payment
    public void Process(decimal amount)
    {
        Console.WriteLine($"\nProcessing Bank Transfer payment of {amount:C}");
    }
}

public class BitcoinPaymentProcessor : IPaymentProcessor
{
    // Method to process Bitcoin payment
    public void Process(decimal amount)
    {
        Console.WriteLine($"\nProcessing Bitcoin payment of {amount:C} in Bitcoin");
    }
}

public class ZainCashPaymentProcessor : IPaymentProcessor
{
    // Method to process ZainCash payment
    public void Process(decimal amount)
    {
        Console.WriteLine($"\nProcessing ZainCash payment of {amount:C}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of PaymentService using PayPal
        PaymentService paymentService = new PaymentService(new PayPalPaymentProcessor());
        paymentService.ProcessPayment(100.00M);

        // Create an instance of PaymentService using Credit Card
        paymentService = new PaymentService(new CreditCardPaymentProcessor());
        paymentService.ProcessPayment(250.50M);

        // Create an instance of PaymentService using Bank Transfer
        paymentService = new PaymentService(new BankTransferPaymentProcessor());
        paymentService.ProcessPayment(500.75M);

        // Create an instance of PaymentService using Bitcoin
        paymentService = new PaymentService(new BitcoinPaymentProcessor());
        paymentService.ProcessPayment(0.005M);

        // Create an instance of PaymentService using ZainCash
        paymentService = new PaymentService(new ZainCashPaymentProcessor());
        paymentService.ProcessPayment(300.00M);

        Console.ReadKey();
    }
}
