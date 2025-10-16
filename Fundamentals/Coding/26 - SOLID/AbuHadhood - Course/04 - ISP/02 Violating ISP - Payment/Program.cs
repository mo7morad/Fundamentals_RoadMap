using System;

public interface IPayment
{
    void PayWithCreditCard();
    void PayWithPayPal();
    void PayWithBitcoin();
}

public class CreditCardPayment : IPayment
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment with credit card.");
    }

    public void PayWithPayPal()
    {
        throw new NotImplementedException();
    }

    public void PayWithBitcoin()
    {
        throw new NotImplementedException();
    }
}

public class PayPalPayment : IPayment
{
    public void PayWithCreditCard()
    {
        throw new NotImplementedException();
    }

    public void PayWithPayPal()
    {
        Console.WriteLine("Payment with PayPal.");
    }

    public void PayWithBitcoin()
    {
        throw new NotImplementedException();
    }
}

public class Program
{
    public static void Main()
    {
        IPayment creditCardPayment = new CreditCardPayment();
        creditCardPayment.PayWithCreditCard();
       // creditCardPayment.PayWithPayPal();
       // creditCardPayment.PayWithBitcoin ();

        IPayment payPalPayment = new PayPalPayment();
        payPalPayment.PayWithPayPal();
        //payPalPayment.PayWithCreditCard();
       // payPalPayment.PayWithBitcoin();

        Console.ReadKey();

    }
}
