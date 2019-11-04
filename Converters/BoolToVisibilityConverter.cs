using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace RicardoBoss.WPF.Converters.ExampleApp
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (!(value is bool b))
                throw new ArgumentException($"value must be of type bool, {value.GetType().FullName} given.",
                    nameof(value));

            return b ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (!(value is Visibility v))
                throw new ArgumentException(
                    $"value must be of type System.Windows.Visibility, {value.GetType().FullName} given.",
                    nameof(value));

            return v.Equals(Visibility.Visible);
        }
    }
}