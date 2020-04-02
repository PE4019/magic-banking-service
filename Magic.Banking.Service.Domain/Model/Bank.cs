using Magic.Banking.Service.Contract.Model;
using Magic.Banking.Service.Domain.Interface;

namespace Magic.Banking.Service.Domain.Model
{
    public class Bank
    {
        private readonly IAccountRepository _accountRepository;

        public Bank(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool CreateAccount(string accountHolder)
        {
            var account = new Account()
            {
                AccountHolder = accountHolder,
                Balance = Money.Gold(0)
            };

            _accountRepository.Insert(account);
            return _accountRepository.Save();
        }

        public bool IsCustomer(string accountHolder)
        {
            var account = _accountRepository.GetByAccountHolder(accountHolder);
            return account != null;
        }

        public Money MakeDeposit(string accountHolder, Money money)
        {
            var balance = GetBalance(accountHolder);
            return balance;
        }

        public Money MakeWithdrawal(string accountHolder, Money money)
        {
            var balance = GetBalance(accountHolder);
            return balance;
        }

        private Money GetBalance(string accountHolder)
        {
            var account = _accountRepository.GetByAccountHolder(accountHolder);
            return account.Balance;
        }
    }
}
