namespace KentBeckTDDSampleCode
{
    public class Franc : Money
    {
        private string currency;

        public Franc(int amount)
        {
            this.currency = "CHF";
            this.Amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
        public override string Currency()
        {
            return currency;
        }
    }
}