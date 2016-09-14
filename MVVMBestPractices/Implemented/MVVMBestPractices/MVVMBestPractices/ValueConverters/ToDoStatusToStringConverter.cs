using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Shared.Enums;
using Xamarin.Forms;

namespace MVVMBestPractices.ValueConverters
{
    class ToDoStatusToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((ToDoStatus)value == ToDoStatus.Open)
                {
                    return "Open";
                }
                else if ((ToDoStatus)value == ToDoStatus.InProgress)
                {
                    return "In Progress";
                }
                else if ((ToDoStatus)value == ToDoStatus.Closed)
                {
                    return "Closed";
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
