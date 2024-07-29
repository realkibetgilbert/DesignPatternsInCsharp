using StrategyDesignPattern.Interfaces;

namespace StrategyDesignPattern.Context
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(float amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
