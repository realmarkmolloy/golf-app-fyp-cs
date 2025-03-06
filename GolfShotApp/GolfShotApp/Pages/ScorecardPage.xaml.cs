using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace GolfShotApp.Pages
{
    public partial class ScorecardPage : ContentPage
    {
        public ObservableCollection<GolfHole> Holes { get; set; }

        public Command SaveScoresCommand { get; }

        public ScorecardPage()
        {
            InitializeComponent();

            Holes = new ObservableCollection<GolfHole>();
            for (int i = 1; i <= 18; i++)
            {
                Holes.Add(new GolfHole { HoleNumber = i });
            }

            SaveScoresCommand = new Command(SaveScores);
            BindingContext = this;
        }

        private void SaveScores()
        {
            // Save logic here
            DisplayAlert("Saved", "Scores have been saved!", "OK");
        }
    }

    public class GolfHole
    {
        public int HoleNumber { get; set; }
        public string Player1Score { get; set; }
        public string Player2Score { get; set; }
        public string Player3Score { get; set; }
        public string Player4Score { get; set; }
    }
}
