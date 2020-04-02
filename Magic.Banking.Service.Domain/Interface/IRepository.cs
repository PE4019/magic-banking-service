namespace Magic.Banking.Service.Domain.Interface
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        T GetById(int id);

        bool Save();
    }
}
