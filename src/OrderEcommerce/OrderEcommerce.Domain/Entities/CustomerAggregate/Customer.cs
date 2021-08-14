using OrderEcommerce.Domain.ValueObjects;
using System;

namespace OrderEcommerce.Domain.Entities.CustomerAggregate
{
    public class Customer
    {
        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Document { get; }
        public Email Email { get; }

        public Customer(string firstName, string lastName, string document, Email email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
        }
    }
}
