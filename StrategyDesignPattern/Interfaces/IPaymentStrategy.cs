namespace StrategyDesignPattern.Interfaces
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(float amount);
    }
}
