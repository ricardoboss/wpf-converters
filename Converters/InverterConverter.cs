using System;
using System.Globalization;
using System.Windows.Data;

namespace RicardoBoss.WPF.Converters.ExampleApp
{
    public class InverterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            return value switch
            {
                bool b => (object) !b,
                int i => -1 * i,
                float f => -1 * f,
                double d => -1 * d,
                _ => throw new ArgumentException($"Type not supported: {value.GetType().FullName}")
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            Convert(value, targetType, parameter, culture);
    }
}