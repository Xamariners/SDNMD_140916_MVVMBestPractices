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
    public class ToDoStatusToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((ToDoStatus)value == ToDoStatus.Open)
                {
                    return ImageSource.FromResource("MVVMBestPractices.Resources.stateopen.png");
                }
                else if ((ToDoStatus)value == ToDoStatus.InProgress)
                {
                    return ImageSource.FromResource("MVVMBestPractices.Resources.stateinprogress.png");
                }
                else if ((ToDoStatus)value == ToDoStatus.Closed)
                {
                    return ImageSource.FromResource("MVVMBestPractices.Resources.stateclosed.png");
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
