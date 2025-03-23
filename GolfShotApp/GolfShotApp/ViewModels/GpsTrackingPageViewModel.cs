using Microsoft.Maui.Devices.Sensors;
using System.Threading.Tasks;

namespace GolfShotApp.ViewModels
{
    public class GpsTrackingPageViewModel : BaseViewModel
    {
        private string _location;
        public string Location
        {
            get => _location;
            set => SetProperty(ref _location, value);
        }

        public Command TrackLocationCommand { get; }

        public GpsTrackingPageViewModel()
        {
            TrackLocationCommand = new Command(async () => await TrackLocation());
        }

        private async Task TrackLocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location != null)
                {
                    Location = $"Lat: {location.Latitude}, Lon: {location.Longitude}";
                }
            }
            catch (Exception ex)
            {
                Location = $"Error: {ex.Message}";
            }
        }
    }
}
