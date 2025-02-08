using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class PasswordRulesProvider : IPasswordRulesProvider
    {
        public IReadOnlyList<string> GetValidationRules()
        {
            return new List<string>
            {
                "Deve ter pelo menos 10 caracteres.",
                "Deve conter pelo menos uma letra (maiúscula ou minúscula).",
                "Deve conter pelo menos um número.",
                "Deve conter pelo menos um símbolo (caractere não alfanumérico)."
            };
        }
    }
}