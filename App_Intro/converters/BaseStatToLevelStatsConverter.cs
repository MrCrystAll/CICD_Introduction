using System;
using System.Globalization;
using System.Windows.Data;
using App_Intro.model;

namespace App_Intro.converters;

public class BaseStatToLevelStatsConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length < 3)
        {
            return null;
        }

        if (values[0] is not Stats stats) return null;
        
        try
        {
            return stats.CalculateStats((int)values[1], (float)values[2]);
        }
        catch (InvalidCastException)
        {
            return null;
        }

        return null;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}