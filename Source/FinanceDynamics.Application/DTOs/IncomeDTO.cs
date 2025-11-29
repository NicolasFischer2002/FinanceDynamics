using FinanceDynamics.Application.Services;

namespace FinanceDynamics.Application.DTOs
{
    public sealed record IncomeDTO
    {
        public string GuidId { get; init; }
        public int Id { get; init; }
        public string Value { get; init; }
        public string Category { get; init; }
        public string SubCategory { get; init; }
        public string TransactionMethod { get; init; }
        public string Date { get; init; }
        public string Description { get; init; }

        public IncomeDTO(string guidId, int id, decimal value, string category, string subCategory, 
            string transactionMethod, DateTime date, string description)
        {
            GuidId = guidId;
            Id = id;
            Value = MoneyFormatterService.Format(value);
            Category = category;
            SubCategory = subCategory;
            TransactionMethod = transactionMethod;
            Date = DateFormatterService.Format_dd_MM_yyyy(date);
            Description = description;
        }
    }
}