namespace Magic.Banking.Service.Contract.Model
{
    public class Gold : Money
    {
        public Gold(uint amount)
        {
            Amount = amount;
        }

        public override string Currency => "Gold";
    }
}
