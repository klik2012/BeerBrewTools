using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace BeerBrewTools.ViewModels
{
    public class DoubleRoundingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            return Round((double)value, parameter);
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            return Round((double)value, parameter);
        }

        double Round(double number, object parameter)
        {
            double precision = 1;

            // Assume parameter is string encoding precision.
            if (parameter != null)
            {
                precision = Double.Parse((string)parameter);
            }
            return precision * Math.Round(number / precision);
        }
    }
}
