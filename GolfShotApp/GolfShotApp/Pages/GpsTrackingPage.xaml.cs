using Microsoft.Maui.Controls;
using Microsoft.Maui.Maps;
using Microsoft.Maui.Devices.Sensors;
using System;
using System.Threading.Tasks;

namespace GolfShotApp.Pages
{
    public partial class GpsTrackingPage : ContentPage
    {
        private readonly double holeLatitude = 53.0937; // Example for Birr Golf Club
        private readonly double holeLongitude = -7.9111;

        public double DistanceToHole { get; set; }

        public Command UpdateDistanceCommand { get; }

        public GpsTrackingPage()
        {
            InitializeComponent();
            UpdateDistanceCommand = new Command(async () => await UpdateDistance());
            BindingContext = this;
        }

        private async Task UpdateDistance()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    DistanceToHole = Location.CalculateDistance(location, new Location(holeLatitude, holeLongitude), DistanceUnits.Kilometers) * 1000;

                    OnPropertyChanged(nameof(DistanceToHole));
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Unable to get location: " + ex.Message, "OK");
            }
        }
    }
}
