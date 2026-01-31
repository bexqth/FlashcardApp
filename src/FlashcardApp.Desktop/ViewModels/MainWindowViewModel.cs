using System;
using System.Linq.Expressions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
namespace FlashcardApp.Desktop.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private DashboardViewModel _dashboardViewModel;
    private ClassesViewModel _classesViewModel;
    private ClassFormViewModel _classFormViewModel;

    [ObservableProperty]
    private bool _sidePanelShow = true;

    [ObservableProperty]
    private ViewModelBase? _currentPage;

    public MainWindowViewModel(
        DashboardViewModel dashboardViewModel,
        ClassesViewModel classesViewModel,
        ClassFormViewModel classFormViewModel)
    {
        _dashboardViewModel = dashboardViewModel;
        _classesViewModel = classesViewModel;
        _classFormViewModel = classFormViewModel;
        ShowDashboardView();
    }

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

    [RelayCommand]
    public void ShowDashboardView()
    {
        CurrentPage = _dashboardViewModel;
    }

    [RelayCommand]
    public void ShowClassesView()
    {
        CurrentPage = _classesViewModel;
    }

    [RelayCommand]
    public void ShowClassFormView()
    {
        CurrentPage = _classFormViewModel;
    }
}
