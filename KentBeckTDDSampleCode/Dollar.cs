
namespace KentBeckTDDSampleCode
{
    public class Dollar: Money
    {
        
        public Dollar(int amount)
        {
            this.Amount=amount;
        }

        public Money Times(int multiplier)
        {
            Dollar five = Money.Dollar(5);
            return new Dollar(Amount * multiplier);
        }

    }
}