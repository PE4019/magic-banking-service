using Magic.Banking.Service.Contract.Model;

namespace Magic.Banking.Service.Contract.DataContract
{
    public class MakeDepositResponse
    {
        public bool IsDeposited { get; set; }

        public Money Balance { get; set; }
    }
}
