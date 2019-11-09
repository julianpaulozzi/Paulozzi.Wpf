using System.Windows;

namespace Paulozzi.Wpf.Core.Framework
{
    public static class DialogOptionsExtensions
    {
        public static DialogOptions SizeToFit(this DialogOptions dialogOptions)
        {
            if (dialogOptions.Height > SystemParameters.VirtualScreenHeight)
            {
                dialogOptions.Height = SystemParameters.VirtualScreenHeight;
            }

            if (dialogOptions.Width > SystemParameters.VirtualScreenWidth)
            {
                dialogOptions.Width = SystemParameters.VirtualScreenWidth;
            }

            return dialogOptions;
        }

        public static DialogOptions SizeToMinSize(this DialogOptions dialogOptions, double factor)
        {
            var height = SystemParameters.WorkArea.Height * factor;
            var width = SystemParameters.WorkArea.Width * factor;

            if (dialogOptions.Height < height)
            {
                dialogOptions.Height = height;
            }

            if (dialogOptions.Width < width)
            {
                dialogOptions.Width = width;
            }

            return dialogOptions;
        }
    }
}