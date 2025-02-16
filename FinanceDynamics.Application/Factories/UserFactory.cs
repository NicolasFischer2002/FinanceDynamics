using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class UserFactory : IUserFactory
    {
        private readonly IPersonValidator _personValidade;
        private readonly IContactFactory _contactFactory;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IPasswordFactory _passwordFactory;

        public UserFactory(IPersonValidator personValidade, IContactFactory contactFactory, 
            ICurrencyRepository currencyRepository, IPasswordFactory passwordFactory)
        {
            _personValidade = personValidade;
            _contactFactory = contactFactory;
            _currencyRepository = currencyRepository;
            _passwordFactory = passwordFactory;
        }

        public User Create(string name, Contact contact, Currency standardCurrency, Password password)
        {
            _personValidade.ValidadeName(name);

            return new User(name, contact, standardCurrency, password, DateTime.Now);
        }

        public User Create(string name, string email, string telephone,
            string codeStandardCurrency, string password)
        {
            Contact contact = _contactFactory.Create(email, telephone);
            Currency currency = _currencyRepository.FindByCode(codeStandardCurrency);
            Password _password = _passwordFactory.Create(password);

            return new User(name, contact, currency, _password, DateTime.Now);
        }
    }
}