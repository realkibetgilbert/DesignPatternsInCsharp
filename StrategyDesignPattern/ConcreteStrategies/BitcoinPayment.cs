using StrategyDesignPattern.Interfaces;

namespace StrategyDesignPattern.ConcreteStrategies
{
    public class BitcoinPayment : IPaymentStrategy
    {
        public void ProcessPayment(float amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of {amount}");
            // Additional Bitcoin-specific logic
        }
    }
}
