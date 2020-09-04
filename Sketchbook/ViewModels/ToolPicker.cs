using System;
using System.Collections.Generic;
using System.Text;

namespace Sketchbook.ViewModels
{
    class ToolPicker
    {
        IList<string> DrawingTools = new List<string>() {
            "red",
            "blue",
            "green",
        };
        String SelectedDrawingTool;

    }
}
