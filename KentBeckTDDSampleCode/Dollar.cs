
namespace KentBeckTDDSampleCode
{
    public class Dollar: Money
    {
        private string currency;

        public Dollar(int amount)
        {
            this.currency = "USD";
            this.Amount=amount;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override string Currency()
        {
            return currency;
        }
    }
}