using System.Windows;
using System.Windows.Interop;

namespace Paulozzi.Wpf.Core.Framework
{
    public static class NativeWindowPlacementExtension
    {
        public static void SetPlacement(this Window window, string placementXml)
        {
            NativeWindowPlacement.SetPlacement(new WindowInteropHelper(window).Handle, placementXml);
        }

        public static string GetPlacement(this Window window)
        {
            return NativeWindowPlacement.GetPlacement(new WindowInteropHelper(window).Handle);
        }
    }
}