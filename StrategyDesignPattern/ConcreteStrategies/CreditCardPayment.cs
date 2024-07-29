using StrategyDesignPattern.Interfaces;

namespace StrategyDesignPattern.ConcreteStrategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(float amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount}");
            // Additional Credit Card-specific logic throw new NotImplementedException();
        }
    }
}
