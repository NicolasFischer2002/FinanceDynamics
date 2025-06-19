using System.ComponentModel;
using System.Reflection;

namespace FinanceDynamics.Domain.Helpers
{
    public static class EnumHelper
    {
        public static IReadOnlyList<(T Value, string Description)> GetValuesAndDescriptions<T>()
            where T : Enum
        {
            var type = typeof(T);
            return Enum
                .GetValues(type)
                .Cast<T>()
                .Select(val =>
                {
                    var fi = type.GetField(val.ToString())!;
                    var da = fi.GetCustomAttribute<DescriptionAttribute>();
                    var desc = da is null
                        ? val.ToString()
                        : da.Description;
                    return (Value: val, Description: desc);
                })
                .ToList();
        }
    }
}