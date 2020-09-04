using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using CColor = System.Drawing.Color;


namespace Sketchbook.ViewModels
{
    public class SketchbookPageViewModel : BaseViewModel
    {     
        IList<string> _drawingTools = new List<string>() {
            "red",
            "blue",
            "green",
        };
        public IList<string> DrawingTools { get { return _drawingTools; } }
        
        String _selectedDrawingTool;
        public String SelectedDrawingTool { 
            get { return _selectedDrawingTool; }
            set
            {
                _selectedDrawingTool = value;
                SetProperty(ref _buttonColor, CColor.FromName(value), "ButtonColor");
            }
        }

        Color _buttonColor = Color.Purple;

        public Color ButtonColor { get { return _buttonColor; } }
    }
}
