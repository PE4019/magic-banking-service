using Magic.Banking.Service.Contract.Model;
using Magic.Banking.Service.Domain.Interface;
using Magic.Banking.Service.Domain.Model;

namespace Magic.Banking.Service.Infrastructure.Persistance.Repositories
{
    public class AccountRepository : IAccountRepository
    {

        public Account GetById(int id)
        {
            return new Account()
            {
                AccountHolder = "Tarkin",
                Balance = Money.Gold(10)
            };
        }

        public Account GetByAccountHolder(string accountHolder)
        {
            if (accountHolder == "Tarkin")
            {
                return new Account()
                {
                    AccountHolder = "Tarkin",
                    Balance = Money.Gold(10)
                };
            }
            else
            {
                return null;
            }
        }

        public void Insert(Account account)
        {
        }

        public bool Save()
        {
            return true;
        }
    }
}
