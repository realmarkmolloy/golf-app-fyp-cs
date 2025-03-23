using System.Collections.ObjectModel;
using System.Windows.Input;
using GolfShotApp.Models;

namespace GolfShotApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<string> Messages { get; set; } = new ObservableCollection<string>();

        private string _greeting;
        public string Greeting
        {
            get => _greeting;
            set => SetProperty(ref _greeting, value);
        }

        public ICommand ShowGreetingCommand { get; }

        public MainPageViewModel()
        {
            Greeting = "Welcome to GolfShotApp!";
            ShowGreetingCommand = new Command(ShowGreeting);
        }

        private void ShowGreeting()
        {
            Messages.Add("Hello, GolfShot Player!");
        }
    }
}
    