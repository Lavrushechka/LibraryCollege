using System.Windows;

namespace LibraryCollege;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnExit_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}