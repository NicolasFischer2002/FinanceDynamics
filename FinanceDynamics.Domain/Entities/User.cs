using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class User : Person
    {
        public Contact Contact { get; private set; }
        public Currency StandardCurrency { get; private set; }
        public Password Password { get; private set; }
        public DateTime DateCreated { get; private set; }

        internal User(string name, Contact contact, Currency standardCurrency, Password password, DateTime dateCreated) 
            : base(name)
        {
            Contact = contact;
            StandardCurrency = standardCurrency;
            Password = password;
            DateCreated = dateCreated;
        }
    }
}