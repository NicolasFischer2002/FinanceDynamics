namespace FinanceDynamics.Application.ValueObjects
{
    public sealed record DateRange
    {
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }

        public DateRange(DateTime startDate, DateTime endDate)
        {
            startDate = RemoveHoursFromDate(startDate);
            endDate = RemoveHoursFromDate(endDate);

            ValidateDates(startDate, endDate);

            StartDate = startDate;
            EndDate = endDate;
        }

        private DateTime RemoveHoursFromDate(DateTime date)
        {
            return date.Date;
        }

        private void ValidateDates(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
                throw new ArgumentException("A data final não pode ser anterior à data inicial.", nameof(endDate));
        }
    }
}