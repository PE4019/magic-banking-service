namespace Magic.Banking.Service.Contract.Model
{
    public class Silver : Money
    {
        public Silver(uint amount)
        {
            Amount = amount;
        }

        public override string Currency => "Silver";
    }
}
