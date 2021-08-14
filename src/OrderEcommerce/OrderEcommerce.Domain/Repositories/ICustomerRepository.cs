using OrderEcommerce.Domain.Entities.CustomerAggregate;

namespace OrderEcommerce.Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetCustomerByDocument(string document);
    }
}
