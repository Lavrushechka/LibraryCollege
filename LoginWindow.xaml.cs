using System.Windows;

namespace LibraryCollege;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void BtnLogin_Click(object sender, RoutedEventArgs e)
    {
        if (TxtLogin.Text == "admin" && TxtPassword.Password == "admin")
        {
            var main = new MainWindow();
            main.Show();
            Close();
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль.");
        }
    }
}