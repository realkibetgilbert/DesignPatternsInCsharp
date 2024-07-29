using StrategyDesignPattern.ConcreteStrategies;
using StrategyDesignPattern.Context;

public class Program
{
    static void Main(string[] args)
    {
        PaymentContext paymentContext = new PaymentContext(new PaypalPayment());
        paymentContext.ProcessPayment(100.0f);

        // Switching the payment method at runtime
        paymentContext.SetPaymentStategy(new BitcoinPayment());
        paymentContext.ProcessPayment(50.0f);
    }
}