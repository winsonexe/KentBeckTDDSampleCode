
namespace KentBeckTDDSampleCode
{
    public class Dollar: Money
    {
        
        public Dollar(int amount)
        {
            this.Amount=amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar) obj;
            return Amount == dollar.Amount;
        }
    }
}