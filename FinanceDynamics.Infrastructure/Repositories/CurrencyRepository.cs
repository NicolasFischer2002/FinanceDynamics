using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Infrastructure.Context;
using FinanceDynamics.Infrastructure.Interfaces;

namespace FinanceDynamics.Infrastructure.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly IMapper<Currency, Models.Currency> _currencyMapper;
        private readonly FinanceDbContext _dbContext;

        // Construtor com injeção de dependência do contexto
        public CurrencyRepository(IMapper<Currency, Models.Currency> currencyMapper, FinanceDbContext dbContext)
        {
            _currencyMapper = currencyMapper;
            _dbContext = dbContext;
        }

        public async ValueTask Add(Currency currency) // Berlim, continuar e testar este método.
        {
            var mappedCurrency = _currencyMapper.Map(currency);
            await _dbContext.AddAsync(mappedCurrency);
        }

        public Currency FindByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}