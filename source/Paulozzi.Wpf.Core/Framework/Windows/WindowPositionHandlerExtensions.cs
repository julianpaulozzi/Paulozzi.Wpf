using System.Windows;

namespace Paulozzi.Wpf.Core.Framework
{
    public static class WindowPositionHandlerExtensions
    {
        public static void AttachPositionHandler(this Window window, IWindowStateStore store, string windowName, bool isMainWindow = false)
        {
            var unused = new WindowStateHandler(store, window, windowName, true) { IsMainWindow = isMainWindow };
        }
    }
}