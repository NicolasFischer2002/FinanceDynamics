using FinanceDynamics.Domain.Interfaces;
using System.Text.RegularExpressions;

namespace FinanceDynamics.Domain.Services
{
    public class ContactValidator : IContactValidator
    {
        /// <summary>
        /// Validates the email address according to a specific pattern.
        /// </summary>
        /// <param name="email">The email address to be validated.</param>
        /// <exception cref="ArgumentNullException">Thrown when the email is null, empty, or consists only of white-space characters.</exception>
        /// <exception cref="ArgumentException">Thrown when the email doesn't match the required format.</exception>
        /// <remarks>
        /// The email is validated using a regular expression that checks for the following:
        /// <para>1. The email should start with a combination of alphanumeric characters, dots, underscores, percent signs, plus signs, or hyphens.</para>
        /// <para>2. The email must have an '@' symbol separating the local part and domain.</para>
        /// <para>3. The domain should consist of alphanumeric characters and may include dots and hyphens.</para>
        /// <para>4. The email should end with a dot followed by a two or more character alphabetic domain extension.</para>
        /// </remarks>
        public void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException(nameof(email), $"O parâmetro [{nameof(email)}] não pode ser vazio.");

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(email))
                throw new ArgumentException($"O parâmetro [{nameof(email)}] não atende aos requisitos.", nameof(email));
        }

        // <summary>
        /// Validates the telephone number to ensure it is not null or empty.
        /// </summary>
        /// <param name="telephone">The telephone number to be validated.</param>
        /// <exception cref="ArgumentNullException">Thrown when the telephone is null, empty, or consists only of white-space characters.</exception>
        public void ValidateTelephone(string telephone)
        {
            if (string.IsNullOrWhiteSpace(telephone))
                throw new ArgumentNullException(nameof(telephone), $"O parâmetro [{nameof(telephone)}] não pode ser vazio.");
        }
    }
}