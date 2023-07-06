using System.Windows;
using ShortBook.SDK.CSharp;

namespace ShortBook.Client.Windows;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            var client = new LoginClient();
            client.Login(TxtUsername.Text, TxtPassword.Text);
        }
        catch (ClientException ex)
        {
            MessageBox.Show(ex.Message, "失败", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}