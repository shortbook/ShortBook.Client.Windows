namespace ShortBook.Client.Windows.ViewModels;

public sealed class LoginViewModel : ViewModel
{
    private string _username;
    private string _password;
    private bool _success;

    public LoginViewModel()
    {
        _success = false;
    }
    
    public string Username
    {
        get => _username;
        set
        {
            if (value == _username) return;
            _username = value;
            OnPropertyChanged();
        }
    }

    public string Password
    {
        get => _password;
        set
        {
            if (value == _password) return;
            _password = value;
            OnPropertyChanged();
        }
    }

    public bool Success
    {
        get => _success;
        set
        {
            if (value == _success) return;
            _success = value;
            OnPropertyChanged();
        }
    }
}