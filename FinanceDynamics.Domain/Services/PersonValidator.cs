using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class PersonValidator : IPersonValidator
    {
        /// <summary>
        /// Validates the person's name.
        /// Throws an exception if the name is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="name">The name to validate.</param>
        public void ValidadeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), $"O parâmetro [{nameof(name)}] não pode ser vazio.");
        }
    }
}