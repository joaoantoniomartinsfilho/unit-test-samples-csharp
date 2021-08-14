using OrderEcommerce.Domain.Entities.CustomerAggregate;
using OrderEcommerce.Domain.Repositories;
using System.Data.Entity;
using System.Linq;

namespace OrderEcommerce.Infra.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }

        public Customer GetCustomerByDocument(string document)
            => _context.Set<Customer>().FirstOrDefault(c => c.Document == document);
    }
}
