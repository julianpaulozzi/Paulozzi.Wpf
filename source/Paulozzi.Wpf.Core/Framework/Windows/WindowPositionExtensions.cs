using System.Windows;

namespace Paulozzi.Wpf.Core.Framework
{
    public static class WindowPositionExtensions
    {
        public static WindowPosition ToWindowPosition(this Window window)
        {
            return WindowPosition.FromWindow(window);
        }

        public static WindowPosition SizeToFit(this WindowPosition windowPosition)
        {
            WindowPosition.SizeToFit(ref windowPosition);

            return windowPosition;
        }

        public static WindowPosition MoveIntoView(this WindowPosition windowPosition)
        {
            WindowPosition.MoveIntoView(ref windowPosition);

            return windowPosition;
        }

        public static WindowPosition SizeToMinSize(this WindowPosition windowPosition, double factor)
        {
            WindowPosition.SizeToMinSize(ref windowPosition, factor);

            return windowPosition;
        }

        public static void ApplyToWindow(this WindowPosition windowPosition, Window window)
        {
            WindowPosition.ToWindow(window, windowPosition);
        }
    }
}