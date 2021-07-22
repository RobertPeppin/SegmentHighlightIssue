using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SegmentControlExample
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel vm;
        public MainPage()
        {
            vm = new MainPageViewModel();
            InitializeComponent();
            this.BindingContext = vm;
        }

        private void ModeSelection_SelectionChanged(object sender, Syncfusion.XForms.Buttons.SelectionChangedEventArgs e)
        {
            if (vm != null)
            {
                // Do something...
            }
        }
    }
}
