using System;
using System.Globalization;

using Xamarin.Forms;

namespace GettingStartedBound.Converter
{
    public class IndentationLevelConverter : IValueConverter
    {
        public const int DEFAULT_INDENTATION_VALUE = 20;
        public int IndentationValueParameter { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int)
            {
                int level = (int)value;
                int? indentationParameter = GetIndendationParameter(parameter);

                var factor = (indentationParameter.HasValue ? indentationParameter.Value : DEFAULT_INDENTATION_VALUE);

                return (level * factor);
            }
            throw new ArgumentException();
        }

        private int? GetIndendationParameter(object parameter)
        {
            if (parameter is int)
            {
                return new int?((int)parameter);
            }
            return new int?();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
