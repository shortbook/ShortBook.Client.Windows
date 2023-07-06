using System.Windows;
using ShortBook.Client.Windows.ViewModels;

namespace ShortBook.Client.Windows
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App
    {
        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            var login = new LoginWindow();
            login.ShowDialog();

            // Determine if login was successful
            if (login.DataContext is LoginViewModel { Success: false })
            {
                // handle any cleanup and close/shutdown app
                Shutdown();
            }

            //show your MainWindow
        }
    }
}
