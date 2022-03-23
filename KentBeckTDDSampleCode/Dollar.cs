
namespace KentBeckTDDSampleCode
{
    public class Dollar: Money
    {
        public Dollar(int amount, string currency)
        {
            this.currency = "USD";
            this.Amount=amount;
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(Amount * multiplier);
        }

    }
}