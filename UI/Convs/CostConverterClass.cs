using System;
using System.Globalization;
using System.Windows.Data;

namespace LearnApp.UI.Convs
{
    /// <summary>
    /// логика перемещения данных о цене и скидке
    /// </summary>
    internal class CostConverterClass : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string cost = "";
            if (values[1] != null)
            {
                cost = Decimal.ToInt16((decimal)values[0]).ToString();
            }
            return cost;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
