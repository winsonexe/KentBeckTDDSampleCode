
namespace KentBeckTDDSampleCode
{
    public class Dollar: Money
    {
        public Dollar(int amount)
        {
            this.Amount=amount;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override string Currency()
        {
            return "USD";
        }
    }
}