using Magic.Banking.Service.Contract.Model;

namespace Magic.Banking.Service.Contract.DataContract
{
    public class MakeWithdrawalResponse
    {
        public bool IsWithdrawed { get; set; }

        public Money Balance { get; set; }
    }
}
