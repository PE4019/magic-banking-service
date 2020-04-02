using Magic.Banking.Service.Domain.Model;

namespace Magic.Banking.Service.Domain.Interface
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetByAccountHolder(string accountHolder);
        void Insert(Account account);
    }
}
