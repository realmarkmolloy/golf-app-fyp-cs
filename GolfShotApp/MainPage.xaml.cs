using System;
using Microsoft.Maui.Controls;

namespace GolfShotApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTrackShotClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrackShotPage());
        }

        private async void OnViewHistoryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShotHistoryPage());
        }

        private async void OnGetTipsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TipsPage());
        }
    }
}
