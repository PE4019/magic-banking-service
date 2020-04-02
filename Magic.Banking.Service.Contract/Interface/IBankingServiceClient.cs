using Magic.Banking.Service.Contract.Model;

namespace Magic.Banking.Service.Contract.Interface
{
    public interface IBankingServiceClient : IServiceClient
    {
        bool CreateAccount(string accountHolder);

        Money MakeDeposit(string accountHolder, Money money);

        Money MakeWithdrawal(string accountHolder, Money money);
    }
}
