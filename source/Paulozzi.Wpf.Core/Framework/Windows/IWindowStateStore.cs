using System.Collections.Generic;

namespace Paulozzi.Wpf.Core.Framework
{
    public interface IWindowStateStore
    {
        Dictionary<string, WindowPosition> WindowPositions { get; set; }
    }
}