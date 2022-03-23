namespace KentBeckTDDSampleCode
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            this.currency = currency;
            this.Amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }
    }
}