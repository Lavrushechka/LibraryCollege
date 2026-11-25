using System.Windows;

namespace LibraryCollege;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnBooks_Click(object sender, RoutedEventArgs e)
    {
        var win = new BookWindow();
        win.Show();
    }

    private void BtnReaders_Click(object sender, RoutedEventArgs e)
    {
        var win = new ReadersWindow();
        win.Show();
    }

    private void BtnCards_Click(object sender, RoutedEventArgs e)
    {
        var win = new CardsWindow();
        win.Show();
    }

    private void BtnToolkit_Click(object sender, RoutedEventArgs e)
    {
        var win = new ToolkitWindow();
        win.Show();
    }

    private void BtnExit_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}