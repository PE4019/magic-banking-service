using System;
using Magic.Banking.Service.Contract.Model;
using Magic.Banking.Service.Domain.Interface;
using Magic.Banking.Service.Domain.Model;

namespace Magic.Banking.Service.Application.UseCases
{
    public class AccountUseCases
    {
        private readonly Bank _bank;
        private readonly IGuildService _guildService;

        public AccountUseCases(IAccountRepository accountRepository, IGuildService guildService)
        {
            _bank = new Bank(accountRepository);
            _guildService = guildService;
        }

        public bool CreateAccount(string accountHolder)
        {
            if (!AccountCanBeCreated(accountHolder)) return false;
            _bank.CreateAccount(accountHolder);
            return true;
        }

        private bool AccountCanBeCreated(string accountHolder)
        {
            return !_guildService.IsAThief(accountHolder) && (!_bank.IsCustomer(accountHolder));
        }

        public Money MakeDeposit(string accountHolder, Money money)
        {
            if (money.Amount < 100) { throw new ArgumentException("Not allowed to deposit amount < 100 units.", nameof(money)); }
            var balance = _bank.MakeDeposit(accountHolder, money);
            return balance;
        }

        public Money MakeWithdrawal(string accountHolder, Money money)
        {
            if(_guildService.IsAThief(accountHolder)) { return Money.Gold(0); }
            var balance = _bank.MakeWithdrawal(accountHolder, money);
            return balance;
        }
    }
}
