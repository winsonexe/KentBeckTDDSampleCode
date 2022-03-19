namespace KentBeckTDDSampleCode
{
    public class Franc
    {
        public int Amount;

        public Franc(int amount)
        {
            this.Amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc franc = (Franc)obj;
            return Amount == franc.Amount;
        }
    }
}