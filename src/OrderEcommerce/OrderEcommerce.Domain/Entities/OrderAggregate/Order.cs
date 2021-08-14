using OrderEcommerce.Domain.Entities.CustomerAggregate;
using OrderEcommerce.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderEcommerce.Domain.Entities.OrderAggregate
{
    public class Order
    {
        public Guid Id { get; }
        public Customer Customer { get; }
        public IReadOnlyCollection<OrderItem> Items { get; }
        public decimal Total => Items.Sum(i => i.UnitPrice * i.Quantity);
        public Address ShippingAddress { get; }
        public Address BillingAddress { get; }
        public DateTime OrderDate { get; }

        public Order(Customer customer, IReadOnlyCollection<OrderItem> items, Address shippingAddress, Address billingAddress)
        {
            ValidateData(customer, items, shippingAddress, billingAddress);

            Id = Guid.NewGuid();

            OrderDate = DateTime.UtcNow;

            Customer = customer;

            Items = items;

            ShippingAddress = shippingAddress;

            BillingAddress = billingAddress;
        }

        //TODO: Find another approach to do validation, throwing exceptions like this has a high resource cost to the software
        private void ValidateData(Customer customer, IReadOnlyCollection<OrderItem> items, Address shippingAddress, Address billingAddress)
        {
            if (customer is null)
                throw new ArgumentNullException($"{nameof(customer)} cannot be null.");

            if (items is null)
                throw new ArgumentNullException($"{nameof(items)} cannot be null.");

            if (shippingAddress is null)
                throw new ArgumentNullException($"{nameof(shippingAddress)} cannot be null.");

            if (billingAddress is null)
                throw new ArgumentNullException($"{nameof(billingAddress)} cannot be null.");            
        }
    }
}
