using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using FlashcardApp.Core.Models;
using FlashcardApp.Core.Services;
using FlashcardApp.Desktop.ViewModels;

namespace FlashcardApp.Desktop.ViewModels;

public partial class ClassesViewModel : ViewModelBase
{

    [ObservableProperty]
    private ObservableCollection<Class> _classes = new();
    
    private ClassService _classService;
    public ClassesViewModel(ClassService classService)
    {
        _classService = classService;
    }

    public async Task RetrieveClasses()
    {
        var list = await _classService.GetAll();
        Classes.Clear();
        foreach (var item in list)
        {
            Classes.Add(item);
        }
    }

    [RelayCommand]
    public void PlusButtonPressed()
    {
        WeakReferenceMessenger.Default.Send(new NavigationMessage<int>(new NavigationData<int>("classFormView", 0)));
    }
}
