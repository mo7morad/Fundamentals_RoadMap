using System;


public interface ICreditCardPayment
{

    void PayWithCreditCard();
}

public interface IPayPalPayment
{

    void PayWithPayPal();

}


public interface IBitCoinPayment
{

    void PayWithBitcoin();

}

public class CreditCardPayment : ICreditCardPayment
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment with credit card.");
    }

   
}

public class PayPalPayment : IPayPalPayment
{
   

    public void PayWithPayPal()
    {
        Console.WriteLine("Payment with PayPal.");
    }

   
}

public class AllPayments : ICreditCardPayment,IPayPalPayment,IBitCoinPayment
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment with credit card.");
    }

    public void PayWithBitcoin()
    {
        Console.WriteLine("Pay with Bitcoin.");
    }

    public void PayWithPayPal()
    {
        Console.WriteLine("Payment with PayPal.");
    }

}

public class Program
{
    public static void Main()
    {
        CreditCardPayment creditCardPayment = new CreditCardPayment();
        creditCardPayment.PayWithCreditCard();


        PayPalPayment payPalPayment = new PayPalPayment();
        payPalPayment.PayWithPayPal();
        
        AllPayments allPayments = new AllPayments();
        allPayments.PayWithCreditCard();
        allPayments.PayWithPayPal();
        allPayments.PayWithBitcoin();


        Console.ReadKey();

    }
}
