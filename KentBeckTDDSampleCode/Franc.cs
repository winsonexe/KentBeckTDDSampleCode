namespace KentBeckTDDSampleCode
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount,currency)
        {
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier,currency);
        }
    }
}