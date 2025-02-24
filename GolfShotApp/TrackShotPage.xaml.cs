using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Maps; 

namespace GolfShotApp
{
    public partial class TrackShotPage : ContentPage
    {
        private const double HoleLatitude = 37.7749;
        private const double HoleLongitude = -122.4194;

        public TrackShotPage()
        {
            InitializeComponent();
            GetLocationAndUpdateMap();
        }

        private async void GetLocationAndUpdateMap()
        {
            try
            {
                
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    
                    GolfCourseMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                        new Location(location.Latitude, location.Longitude), Distance.FromMiles(0.5))); 

                    
                    GolfCourseMap.Pins.Add(new Pin
                    {
                        Location = new Location(location.Latitude, location.Longitude),
                        Label = "You are here",
                        Address = "Current Location"
                    });

                    
                    var distanceToHole = Location.CalculateDistance(location,
                        new Location(HoleLatitude, HoleLongitude), DistanceUnits.Miles);

                    
                    DistanceLabel.Text = $"Distance to Hole: {distanceToHole:F2} miles";
                }
            }
            catch (Exception ex)
            {
                
                DistanceLabel.Text = "Unable to get location.";
            }
        }
    }
}
