using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Domain.Services
{
    public class NameAndDescriptionValidator : INameAndDescriptionValidator
    {
        private const int CharacterLimitForDescription = 100;

        /// <summary>
        /// Validates the name and description by applying guard clauses for each parameter.
        /// </summary>
        /// <param name="name">The name to be validated.</param>
        /// <param name="description">The description to be validated. It can be null.</param>
        public void Validate(string name, string? description)
        {
            ValidateName(name);
            ValidateDescription(description);
        }

        /// <summary>
        /// Validates the name to ensure it is not null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="name">The name to be validated.</param>
        /// <exception cref="ArgumentNullException">Thrown when the name is null, empty, or consists only of white-space characters.</exception>
        public void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), $"O parâmetro [{nameof(name)}] não pode ser vazio.");
        }

        /// <summary>
        /// Validates the description to ensure it does not exceed the character limit
        /// and is not null or whitespace.
        /// </summary>
        /// <param name="description">The description to be validated. It can be null.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the description exceeds the allowed character limit of 
        /// <see cref="CharacterLimitForDescription"/>.
        /// </exception>
        public void ValidateDescription(string? description)
        {
            if (!string.IsNullOrWhiteSpace(description))
            {
                if (description.Length > CharacterLimitForDescription)
                    throw new ArgumentOutOfRangeException(nameof(description),
                        $"A descrição informada excede ao limite de caracteres: [{CharacterLimitForDescription}]");
            }
        }
    }
}