namespace KentBeckTDDSampleCode
{
    public class Money
    {
        protected int Amount; //子類別都能看見

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount&& GetType().Equals(money.GetType());
        }

        protected static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }
    }
}