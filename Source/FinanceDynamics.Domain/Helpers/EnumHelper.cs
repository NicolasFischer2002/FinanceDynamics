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

        public static T GetValueFromDescription<T>(string description)
            where T : Enum
        {
            var type = typeof(T);
            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                var attr = field.GetCustomAttribute<DescriptionAttribute>();
                if (attr != null && attr.Description == description)
                    return (T)field.GetValue(null)!;
                
                if (attr == null && field.Name.Equals(description, StringComparison.InvariantCultureIgnoreCase))
                    return (T)field.GetValue(null)!;
            }

            throw new ArgumentException($"Descrição '{description}' não encontrada em {type.Name}.");
        }

        public static T GetValueFromName<T>(string name, bool ignoreCase = true)
        where T : struct, Enum
        {
            if (Enum.TryParse<T>(name, ignoreCase, out var value))
                return value;

            throw new ArgumentException(
                $"Nome '{name}' não corresponde a nenhum valor do enum {typeof(T).Name}.",
                nameof(name)
            );
        }
    }
}