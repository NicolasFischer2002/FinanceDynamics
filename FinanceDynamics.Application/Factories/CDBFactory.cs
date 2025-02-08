using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Application.Factories
{
    public class CDBFactory : ICDBFactory
    {
        private readonly ICDBValidator _CDBValidator;

        public CDBFactory(ICDBValidator CDBValidator)
        {
            _CDBValidator = CDBValidator;   
        }

        public CDB Create(Guid userId, decimal value, decimal transactionFee, string? description, DateTime date, 
            FixedIncomeFinancialInstitution fixedIncomeFinancialInstitution, 
            bool immediateWithdrawal, int investmentDuration)
        {
            _CDBValidator.Validate(investmentDuration);

            return new CDB(
                userId, 
                value, 
                transactionFee, 
                description, 
                date, 
                fixedIncomeFinancialInstitution, 
                immediateWithdrawal, 
                investmentDuration
            );
        }
    }
}