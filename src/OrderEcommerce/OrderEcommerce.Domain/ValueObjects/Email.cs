using System.Collections.Generic;

namespace OrderEcommerce.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Text { get; private set;  }

        public string Domain { get; private set;  }

        public Email(string text, string domain)
        {
            Text = text;
            Domain = domain;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Text;
            yield return Domain;
        }

        public override string ToString()
         => Text;   
    }
}
