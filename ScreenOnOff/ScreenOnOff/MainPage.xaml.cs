using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace ScreenOnOff
{
    public partial class MainPage : ContentPage
    {       
        public MainPage()
        {
            InitializeComponent();
            DeviceDisplay.KeepScreenOn = true;
        }

        private async void TurnOffClick(object sender, EventArgs args)
        {
            DeviceDisplay.KeepScreenOn = false;
            //DeviceDisplay.KeepScreenOn = false;
            var x = DeviceDisplay.KeepScreenOn;
            await DisplayAlert("Test Titel", x.ToString(), "ok");
        }
        private async void TurnOnClick(object sender, EventArgs args)
        {   
            DeviceDisplay.KeepScreenOn = true;
            //DeviceDisplay.KeepScreenOn = false;
            var x = DeviceDisplay.KeepScreenOn;
            await DisplayAlert("Test Titel", x.ToString(), "ok");             
        }
    }
}
