using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.MVVM.Converts
{
    public class BoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            var boolValue = (bool)value;
            if (boolValue == true)
            {
                return "Si";
            }

            return "No";
        }

        public object ConvertBack(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            var stringValue = (string)value;
            if (stringValue == "Si")
            {
                return true;
            }

            return false;
        }
    }
}