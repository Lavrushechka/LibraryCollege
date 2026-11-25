using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace LibraryCollege.Converters;

public class BoolToStatusConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => value is true ? "Активен" : "Заблокирован";

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => value is string s && s == "Активен";
}

public class BoolToBrushConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => value is true ? Brushes.Green : Brushes.Red;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => throw new NotImplementedException();
}