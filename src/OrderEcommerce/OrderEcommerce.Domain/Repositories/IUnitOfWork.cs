using System.Threading.Tasks;

namespace OrderEcommerce.Domain.Repositories
{
    public interface IUnitOfWork
    {
        public IOrderRepository OrderRepositoy { get; }
        public ICustomerRepository CustomerRepository { get; }

        int Commit();
        Task<int> CommitAsync();
    }
}
