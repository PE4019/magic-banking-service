using Magic.Banking.Service.Contract.Model;
using Magic.Banking.Service.Domain.Interface;

namespace Magic.Banking.Service.Domain.Model
{
    public class Account : IAggregateRoot
    {
        public int Id { get; set; }

        public string AccountHolder { get; set; }

        public Money Balance { get; set; }
    }
}
