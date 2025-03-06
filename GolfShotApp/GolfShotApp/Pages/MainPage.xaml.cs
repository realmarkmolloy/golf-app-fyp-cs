using GolfShotApp.Models;
using GolfShotApp.PageModels;

namespace GolfShotApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }
}
