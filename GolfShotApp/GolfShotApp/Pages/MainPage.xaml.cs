using GolfShotApp.Models;
using GolfShotApp.PageModels;
using Microsoft.Maui.Controls;
using Microsoft.EntityFrameworkCore;
using GolfShotApp.ViewModels;

namespace GolfShotApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
