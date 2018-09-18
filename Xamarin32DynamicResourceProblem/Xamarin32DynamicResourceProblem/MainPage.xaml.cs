using System;
using Xamarin.Forms;

namespace Xamarin32DynamicResourceProblem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ApplyLongStyle(object sender, EventArgs e)
        {
            Resources["paddingStyle"] = Resources["longStyle"];

        }

        private void ApplyShortStyle(object sender, EventArgs e)
        {
            Resources["paddingStyle"] = Resources["shortStyle"];
        }
    }
}
