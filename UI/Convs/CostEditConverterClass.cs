using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LearnApp.UI.Convs
{
    internal class CostEditConverterClass : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            else
            {
                return (double)value * 100;
            }


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double result;
            if (value == null) return null;
            {
                return Double.Parse(value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
            }
           

        }
    }
}
