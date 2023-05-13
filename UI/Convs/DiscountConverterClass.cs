using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LearnApp.UI.Convs
{
    /// <summary>
    /// логика перемещения данных скидке
    /// </summary>
    internal class DiscountConverterClass : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string result = "";
            if (value != null)
            {
                result = "* скидка " + ((double)value*100).ToString() +"%";
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
