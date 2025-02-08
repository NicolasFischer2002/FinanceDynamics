using FinanceDynamics.Domain.Interfaces;
using System.Text.RegularExpressions;

namespace FinanceDynamics.Domain.Services
{
    public class PasswordValidator : IPasswordValidator
    {
        /// <summary>
        /// Validates if the provided password meets the required criteria:
        /// <para>- At least 10 characters long.</para>
        /// <para>- Contains at least one letter (uppercase or lowercase).</para>
        /// <para>- Contains at least one number.</para>
        /// <para>- Contains at least one symbol (non-alphanumeric character).</para>
        /// </summary>
        /// <param name="password">The password string to validate.</param>
        /// <exception cref="ArgumentNullException">Thrown if the password is null, empty, or consists only of white-space characters.</exception>
        /// <exception cref="ArgumentException">Thrown if the password does not meet the required criteria.</exception>
        public void Validate(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password), $"[The parameter {nameof(password)}] cannot be empty or null.");

            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[\W_]).{10,}$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(password))
                throw new ArgumentException($"The parameter [{nameof(password)}] does not meet the required criteria.", nameof(password));
        }
    }
}
