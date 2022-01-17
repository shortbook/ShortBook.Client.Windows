using System;
using System.Diagnostics;
using System.Windows;
using ShortBook.SDK.CSharp;

namespace ShortBook.Client.Windows
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
}
