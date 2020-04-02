using Magic.Banking.Service.Application.UseCases;
using Magic.Banking.Service.Contract.DataContract;
using Magic.Banking.Service.Domain.Interface;
using Magic.Banking.Service.Infrastructure.Com.GuildService;
using Magic.Banking.Service.Infrastructure.Persistance.Repositories;

namespace Magic.Banking.Service.WebApi.Controllers
{
    public class BankingController
    {
        private readonly AccountUseCases _accountUseCase;

        public BankingController()
        {
            //IAccountRepository accountRepository = new AccountRepository();
            IAccountRepository accountRepository = new AccountRepositoryInMem();
            IGuildService guildService = new GuildService();
            _accountUseCase = new AccountUseCases(accountRepository, guildService);
        }

        public CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            var accountHolder = request.AccountHolder;
            var isCreated = _accountUseCase.CreateAccount(accountHolder);
            var response = new CreateAccountResponse()
            {
                IsCreated = isCreated
            };

            return response;
        }

        public MakeDepositResponse MakeDeposit(MakeDepositRequest request)
        {
            var balance = _accountUseCase.MakeDeposit(request.AccountHolder, request.Money);
            var response = new MakeDepositResponse()
            {
                IsDeposited = true,
                Balance = balance
            };

            return response;
        }

        public MakeWithdrawalResponse MakeWithdrawal(MakeWithdrawalRequest request)
        {
            var balance = _accountUseCase.MakeWithdrawal(request.AccountHolder, request.Money);
            var response = new MakeWithdrawalResponse()
            {
                IsWithdrawed = true,
                Balance = balance
            };

            return response;
        }
    }
}
