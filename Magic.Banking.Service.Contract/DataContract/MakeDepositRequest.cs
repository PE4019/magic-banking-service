using Magic.Banking.Service.Contract.Model;

namespace Magic.Banking.Service.Contract.DataContract
{
    public class MakeDepositRequest
    {
        public string AccountHolder { get; set; }

        public Money Money { get; set; }
    }
}
