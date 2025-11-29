using FinanceDynamics.Application.Services;

namespace FinanceDynamics.Presentation.DTOs
{
    public sealed record TransactionDTO
    {
        public int Id { get; init; }
        public string GuidId { get; init; }
        public string Value { get; init; }
        public string Category { get; init; }
        public string SubCategory { get; init; }
        public string TransactionMethod { get; init; }
        public string Date {  get; init; }
        public string Description { get; init; }

        public TransactionDTO(int id, Guid guidId, decimal value, string category, string? subCategory, 
            string transactionMethod, DateTime date, string? description)
        {
            Id = id;
            GuidId = guidId.ToString();
            Value = MoneyFormatterService.Format(value);
            Category = category;
            SubCategory = subCategory ?? string.Empty;
            TransactionMethod = transactionMethod;
            Date = date.ToString("dd/MM/yyyy");
            Description = description ?? string.Empty;
        }

        public TransactionDTO(int id, string guidId, string value, string category, string? subCategory,
            string transactionMethod, string date, string? description)
        {
            Id = id;
            GuidId = guidId;
            Value = value;
            Category = category;
            SubCategory = string.Empty;
            TransactionMethod = transactionMethod;
            Date = date;
            Description = description is null ? string.Empty : description;
        }
    }
}