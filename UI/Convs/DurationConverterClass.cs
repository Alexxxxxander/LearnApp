using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LearnApp.UI.Convs
{
    /// <summary>
    /// логика перемещения данных о цене и скидке
    /// </summary>
    internal class DurationConverterClass : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string result;
            if (values[1] != null)
            {
                double newcost = Decimal.ToDouble((decimal)values[0]) - Decimal.ToDouble((decimal)values[0]) * (double)values[1];
                result = newcost + " рублей за " + (int)values[2] + " минут\n";
            }
            else
            {
                result = Decimal.ToInt16((decimal)values[0]) + " рублей за " + (int)values[2] + " минут\n";
            }
            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
