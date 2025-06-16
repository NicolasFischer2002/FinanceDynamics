
namespace FinanceDynamics.Domain.Exceptions
{
    internal class DomainException : CustomException<string>
    {
        public DomainException(string message, string invalidValue) 
            : base(message, invalidValue)
        {

        }

        public DomainException(string message, string invalidValue, Exception innerException) 
            : base(message, invalidValue, innerException)
        {

        }
    }
}