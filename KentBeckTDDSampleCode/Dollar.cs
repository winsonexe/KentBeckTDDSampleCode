namespace KentBeckTDDSampleCode
{
    public class Dollar
    {
        public int Amount;

        public Dollar(int amount)
        {
            this.Amount=amount;
        }

        public Dollar Times(int multiplier)
        {
            Amount *= multiplier;
            return null;
        }
    }
}