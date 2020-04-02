using Magic.Banking.Service.Contract.DataContract;
using Magic.Banking.Service.Contract.Interface;
using Magic.Banking.Service.Contract.Model;
using Magic.Banking.Service.WebApi.Controllers;

namespace Magic.Banking.Service.Client
{
    public class BankingServiceClient : IBankingServiceClient
    {
        private readonly BankingController _controller = new BankingController();

        public bool IsAlive()
        {
            return true;
        }

        public bool CreateAccount(string accountHolder)
        {
            var request = new CreateAccountRequest()
            {
                AccountHolder = accountHolder
            };

            var response = _controller.CreateAccount(request);
            return response.IsCreated;
        }

        public Money MakeDeposit(string accountHolder, Money money)
        {
            var request = new MakeDepositRequest()
            {
                AccountHolder = accountHolder,
                Money = money
            };

            var response = _controller.MakeDeposit(request);
            return response.Balance;
        }

        public Money MakeWithdrawal(string accountHolder, Money money)
        {
            var request = new MakeWithdrawalRequest()
            {
                AccountHolder = accountHolder,
                Money = money
            };

            var controller = new BankingController();
            var result = _controller.MakeWithdrawal(request);
            return result.Balance;
        }
    }
}

