using System;


public class OrderEventArgs : EventArgs
{
    public int OrderID { get;  }
    public int OrderTotalPrice { get; }
    public string ClientEmail { get; }


    public OrderEventArgs (int orderID, int orderTotalPrice, string clientEmail)
    { 
        this.OrderID = orderID; 
        this.OrderTotalPrice = orderTotalPrice;
        this.ClientEmail = clientEmail;
    }

}

public class Order
{
    public event EventHandler <OrderEventArgs> OnOrderCreated;

    public void Create(int orderID, int orderTotalPrice, string clientEmail )
    {
        Console.WriteLine("New Order created; now will notify eveyone by raising the event.\n");

        if (OnOrderCreated != null)
        {
            OnOrderCreated(this, new OrderEventArgs(orderID,orderTotalPrice,clientEmail));
        }
    }
}

public class EmailService
{
    public void Subscribe(Order order)
    {
        order.OnOrderCreated += HandleNewOrder;
    }

    public void UnSubscribe(Order order)
    {
        order.OnOrderCreated -= HandleNewOrder;
    }

    public void HandleNewOrder(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"----------Email Service--------");
        Console.WriteLine($"Email Service Object Received a new order event");
        Console.WriteLine($"Order ID: {e.OrderID}");
        Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
        Console.WriteLine($"Email: {e.ClientEmail}");
        Console.WriteLine($"\nSend an email");
        Console.WriteLine($"--------------------------------");
        Console.WriteLine();


    }
}

public class SMSService
{
   

    public void Subscribe(Order order)
    {
        order.OnOrderCreated += HandleNewOrder;
    }


    public void UnSubscribe(Order order)
    {
        order.OnOrderCreated -= HandleNewOrder;
    }

    public void HandleNewOrder(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"------------SMS Service--------");
        Console.WriteLine($"SMS Service Object Received a new order event");
        Console.WriteLine($"Order ID: {e.OrderID}");
        Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
        Console.WriteLine($"Email: {e.ClientEmail}");
        Console.WriteLine($"\nSend SMS");
        Console.WriteLine($"--------------------------------");
        Console.WriteLine();


    }
}

public class ShippingService
{


    public void Subscribe(Order order)
    {
        order.OnOrderCreated += HandleNewOrder;
    }


    public void UnSubscribe(Order order)
    {
        order.OnOrderCreated -= HandleNewOrder;
    }

    public void HandleNewOrder(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"---------Shipping Service-------");
        Console.WriteLine($"Shipping Service Object Received a new order event");
        Console.WriteLine($"Order ID: {e.OrderID}");
        Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
        Console.WriteLine($"Email: {e.ClientEmail}");
        Console.WriteLine($"\nHandel Shipping");
        Console.WriteLine($"--------------------------------");
        /*
         here you write the code to handel shipping to the client 
         */
        Console.WriteLine();


    }
}


class Program
{
    static void Main(string[] args)
    {

        object x = "morad";
        x.ToString();

        Order order = new Order();
        EmailService emailService = new EmailService();
        SMSService smsService = new SMSService();
        ShippingService shippingService = new ShippingService();


        emailService.Subscribe(order);
        smsService.Subscribe(order);
        shippingService.Subscribe(order);
        shippingService.UnSubscribe(order);

        order.Create(10,540,"Ahmed@gmail.com");
        Console.ReadLine();
    }
}
