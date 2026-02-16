using FinanceDynamics.Application.ValueObjects;

namespace FinanceDynamics.Application.Services
{
    public sealed class DateRangeState
    {
        public DateRange Current { get; private set; }

        public event Action? OnChange;

        public DateRangeState()
        {
            var today = DateTime.Today;
            var startOfMonth = new DateTime(today.Year, today.Month, 1);
            var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            Current = new DateRange(startOfMonth, endOfMonth);
        }

        public void SetDateRange(DateRange newRange)
        {
            Current = newRange;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
            => OnChange?.Invoke();
    }
}