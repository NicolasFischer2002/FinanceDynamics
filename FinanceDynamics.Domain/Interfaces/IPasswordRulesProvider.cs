namespace FinanceDynamics.Domain.Interfaces
{
    public interface IPasswordRulesProvider
    {
        IReadOnlyList<string> GetValidationRules();
    }
}