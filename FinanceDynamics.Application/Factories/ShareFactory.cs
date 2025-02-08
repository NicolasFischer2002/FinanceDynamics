using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Application.Factories
{
    public class ShareFactory : IShareFactory
    {
        private readonly IShareValidator _shareValidator;
        private readonly IShareCalculate _shareCalculate;

        public ShareFactory(IShareValidator shareValidator, IShareCalculate shareCalculate)
        {
            _shareValidator = shareValidator;
            _shareCalculate = shareCalculate;
        }

        public Share Create(Guid userId, decimal value, decimal transactionFee, string? description, DateTime date, 
            VariableIncomeFinancialInstitution variableIncomeFinancialInstitution, int quantity, 
            string symbol, string company)
        {
            decimal pricePerUnit = _shareCalculate.PricePerUnit(value, quantity);

            _shareValidator.Validate(quantity, pricePerUnit, symbol, company);

            return new Share(
                userId,
                value,
                transactionFee,
                description,
                date,
                variableIncomeFinancialInstitution,
                quantity,
                pricePerUnit,
                symbol,
                company
            );
        }
    }
}