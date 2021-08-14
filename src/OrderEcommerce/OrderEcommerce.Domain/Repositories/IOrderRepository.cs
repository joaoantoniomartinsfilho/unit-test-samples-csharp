using OrderEcommerce.Domain.Entities.OrderAggregate;
using System;

namespace OrderEcommerce.Domain.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        OrderItem GetItemsFromOrder(Guid orderId);
    }
}
