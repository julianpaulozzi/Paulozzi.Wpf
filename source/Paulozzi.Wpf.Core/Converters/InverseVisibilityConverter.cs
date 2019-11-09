using System.Globalization;
using System.Windows;

namespace Paulozzi.Wpf.Core.Converters
{
    public class InverseVisibilityConverter : ConverterBase<Visibility, Visibility>
    {
        public override Visibility Convert(Visibility value, CultureInfo culture)
        {
            return value == Visibility.Hidden || value == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}