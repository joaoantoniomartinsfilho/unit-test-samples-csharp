using System;

namespace OrderEcommerce.Domain.Entities.OrderAggregate
{
    public class OrderItem
    {
        public Guid OrderId { get; }
        public decimal UnitPrice { get; }
        public int Quantity { get; }

        public virtual Order Order { get; }
    }
}
