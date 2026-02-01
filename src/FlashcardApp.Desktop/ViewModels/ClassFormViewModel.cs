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

public partial class ClassFormViewModel : ViewModelBase
{

    [ObservableProperty]
    private string _className = string.Empty;

    [ObservableProperty]
    private string _classHexColor = "#746882";

    public Guid? _id {get; set;} = null;

    private ClassService _classService;

    public ClassFormViewModel(ClassService classService)
    {
        _classService = classService;
    }

    [RelayCommand]
    public void BackButtonPressed ()
    {
        WeakReferenceMessenger.Default.Send(new NavigationMessage<int>(new NavigationData<int>("classesView", 0)));
    }

    [RelayCommand]
    public async Task CreateClassButtonPressed()
    {
        var formClass = new Class{
            ClassName = ClassName,
            HexColor = ClassHexColor
        };

        if (_id == null)
        {
            await CreateClass(formClass);
        } else
        {
            EditClass();
        }
    }

    public async Task CreateClass(Class formClass)
    {
        try
        {
            var c = await _classService.Create(formClass);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void EditClass()
    {
        
    }

    [RelayCommand]
    public void ColorButtonPressed(string selectedColorHex)
    {
        ClassHexColor = selectedColorHex;
    }

    public void ClearForm()
    {
        ClassName = string.Empty;
        ClassHexColor = string.Empty;
        _id = null;
    }
}
