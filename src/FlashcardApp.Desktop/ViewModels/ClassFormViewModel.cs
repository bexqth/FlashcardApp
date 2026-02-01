using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using FlashcardApp.Desktop.ViewModels;

namespace FlashcardApp.Desktop.ViewModels;

public partial class ClassFormViewModel : ViewModelBase
{

    public ClassFormViewModel()
    {

    }

    [RelayCommand]
    public void BackButtonPressed ()
    {
        WeakReferenceMessenger.Default.Send(new NavigationMessage<int>(new NavigationData<int>("classesView", 0)));
    }
}
