using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Maps; // For Map, Pin
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Maps; // For Geolocation and Location

namespace GolfShotApp
{
    public partial class TrackShotPage : ContentPage
    {
        private const double HoleLatitude = 37.7749; // Replace with actual hole latitude
        private const double HoleLongitude = -122.4194; // Replace with actual hole longitude

        public TrackShotPage()
        {
            InitializeComponent();
            GetLocationAndUpdateMap();
        }

        private async void GetLocationAndUpdateMap()
        {
            try
            {
                // Get the user's location
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    // Move map to user's location
                    GolfCourseMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                        new Location(location.Latitude, location.Longitude), Distance.FromMiles(0.5))); // Updated

                    // Show the user's location on the map
                    GolfCourseMap.Pins.Add(new Pin
                    {
                        Location = new Location(location.Latitude, location.Longitude), // Updated
                        Label = "You are here",
                        Address = "Current Location"
                    });

                    // Calculate distance to the hole
                    var distanceToHole = Location.CalculateDistance(location,
                        new Location(HoleLatitude, HoleLongitude), DistanceUnits.Miles);

                    // Update the distance label
                    DistanceLabel.Text = $"Distance to Hole: {distanceToHole:F2} miles";
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., location permissions not granted)
                DistanceLabel.Text = "Unable to get location.";
            }
        }
    }
}
