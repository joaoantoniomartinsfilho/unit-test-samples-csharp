using OrderEcommerce.Domain.Repositories;
using System.Data.Entity;
using System.Threading.Tasks;

namespace OrderEcommerce.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IOrderRepository OrderRepositoy { get; }
        public ICustomerRepository CustomerRepository { get; }

        public UnitOfWork(DbContext context, IOrderRepository orderRepositoy, ICustomerRepository customerRepository)
        {
            OrderRepositoy = orderRepositoy;
            CustomerRepository = customerRepository;

            _context = context;
        }

        public int Commit()
            => _context.SaveChanges();

        public Task<int> CommitAsync()
            => _context.SaveChangesAsync();
    }
}
