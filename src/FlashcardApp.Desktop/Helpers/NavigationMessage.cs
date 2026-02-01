using CommunityToolkit.Mvvm.Messaging.Messages;

public record NavigationData<T>(string ViewName, T? arg);

public class NavigationMessage<T> : ValueChangedMessage<NavigationData<T>>
{
    public NavigationMessage(NavigationData<T> data) : base(data)
    {      
    }
}