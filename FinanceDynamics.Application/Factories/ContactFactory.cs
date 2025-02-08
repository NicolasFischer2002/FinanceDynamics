using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class ContactFactory : IContactFactory
    {
        private readonly IContactValidator _validator;

        public ContactFactory(IContactValidator validator)
        {
            _validator = validator;
        }

        public Contact Create(string email, string telephone)
        {
            _validator.ValidateEmail(email);
            _validator.ValidateTelephone(telephone);

            return new Contact(email, telephone);
        }
    }
}