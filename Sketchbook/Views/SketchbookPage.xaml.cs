using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sketchbook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SketchbookPage : ContentPage
    {
        public SketchbookPage()
        {
            InitializeComponent();
        }
        void OnToolButtonClicked(object sender, EventArgs e)
        {
            ToolList.IsVisible = !ToolList.IsVisible;
        }
    }
}