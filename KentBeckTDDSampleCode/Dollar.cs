
namespace KentBeckTDDSampleCode
{
    public class Dollar: Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier,currency);
        }

    }
}