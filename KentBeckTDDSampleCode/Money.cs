namespace KentBeckTDDSampleCode
{
    public class Money
    {
        protected int Amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.currency = currency;
            this.Amount = amount;
        }

        public Money Times(int multiplier)
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount&& GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public string Currency()
        {
            return currency;
        }
    }
}