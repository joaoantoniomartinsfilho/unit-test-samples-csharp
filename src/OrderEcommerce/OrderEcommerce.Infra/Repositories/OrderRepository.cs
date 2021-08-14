using OrderEcommerce.Domain.Entities.OrderAggregate;
using OrderEcommerce.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OrderEcommerce.Infra.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {

        public OrderRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<OrderItem> GetItemsByOrderId(Guid orderId)
            => _context.Set<OrderItem>().Where(i => i.OrderId == orderId);
    }
}
