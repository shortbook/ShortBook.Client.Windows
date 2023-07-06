using System.ComponentModel;
using System.Runtime.CompilerServices;
using ShortBook.Client.Windows.Annotations;

namespace ShortBook.Client.Windows.ViewModels;

public class ViewModel : INotifyPropertyChanged
{
    /// <summary>Occurs when a property value changes.</summary>
    public event PropertyChangedEventHandler PropertyChanged;
    
    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}