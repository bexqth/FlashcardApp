using System;
using System.Linq.Expressions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
namespace FlashcardApp.Desktop.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _sidePanelShow = true;

    [ObservableProperty]
    private ViewModelBase? _currentPage;

    public string Greeting { get; } = "Welcome to Avalonia!";

    [RelayCommand]
    public void SideButtonPressed()
    {
        Console.WriteLine(SidePanelShow);
        if(SidePanelShow)
        {
            SidePanelShow = false;
        }
        else
        {
            SidePanelShow = true;
        }
    }
}
