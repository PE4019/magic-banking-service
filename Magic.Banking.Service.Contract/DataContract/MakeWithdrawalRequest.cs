using Magic.Banking.Service.Contract.Model;

namespace Magic.Banking.Service.Contract.DataContract
{
    public class MakeWithdrawalRequest
    {
        public string AccountHolder { get; set; }

        public Money Money { get; set; }
    }
}
