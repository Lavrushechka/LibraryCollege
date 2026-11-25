using System.Windows;

namespace LibraryCollege;

public partial class CommandsWindow : Window
{
    public CommandsWindow()
    {
        InitializeComponent();
        DataContext = new BooksViewModel();
    }
}