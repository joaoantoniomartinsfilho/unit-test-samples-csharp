using System.Collections.Generic;

namespace OrderEcommerce.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public int Number { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Street;
            yield return City;
            yield return State;
            yield return Country;
            yield return ZipCode;
            yield return Number;
        }

        public override string ToString()
        => $"{Street} - {ZipCode} - {Number}, {City}, {State}, {Country}";
    }
}
