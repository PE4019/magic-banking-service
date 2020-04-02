namespace Magic.Banking.Service.Contract.Model
{
    public abstract class Money
    {
        public uint Amount { get; protected set; }

        public abstract string Currency { get; }

        public static Money Gold(uint amount)
        {
            return new Gold(amount);
        }

        public static Money Silver(uint amount)
        {
            return new Silver(amount);
        }

        public override string ToString()
        {
            return $"{Amount} in {Currency}";
        }
    }
}
