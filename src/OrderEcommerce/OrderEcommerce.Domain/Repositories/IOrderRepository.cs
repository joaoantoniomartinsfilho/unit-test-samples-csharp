using OrderEcommerce.Domain.Entities.OrderAggregate;
using System;
using System.Collections.Generic;

namespace OrderEcommerce.Domain.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<OrderItem> GetItemsByOrderId(Guid orderId);
    }
}
