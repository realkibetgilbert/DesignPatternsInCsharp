using StrategyDesignPattern.Interfaces;

namespace StrategyDesignPattern.ConcreteStrategies
{
    public class PaypalPayment : IPaymentStrategy
    {
        public void ProcessPayment(float amount)
        {
            Console.WriteLine($"Processing PayPal Payment of {amount}");
            //Add Additional Logic For Paypal Payment
        }
    }
}
