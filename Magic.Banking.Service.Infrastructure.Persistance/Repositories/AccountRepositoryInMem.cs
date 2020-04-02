using Magic.Banking.Service.Domain.Interface;
using Magic.Banking.Service.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Magic.Banking.Service.Infrastructure.Persistance.Repositories
{
    public class AccountRepositoryInMem : IAccountRepository
    {
        private readonly List<Account> _accounts = new List<Account>();

        public Account GetById(int id)
        {
            return _accounts.FirstOrDefault(a => a.Id == id);
        }

        public Account GetByAccountHolder(string accountHolder)
        {
            return _accounts.FirstOrDefault(a => a.AccountHolder == accountHolder);
        }

        public void Insert(Account account)
        {
            if (GetByAccountHolder(account.AccountHolder) != null)
            {
                _accounts.Add(account);
            }
        }

        public bool Save()
        {
            return true;
        }
    }
}
