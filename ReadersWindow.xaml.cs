using System.Windows;
using LibraryCollege.Models;

namespace LibraryCollege;

public partial class ReadersWindow : Window
{
    public ReadersWindow()
    {
        InitializeComponent();
        DataContext = new Reader
        {
            FullName = "Щербакова Екатерина Александровна",
            Group = "ИС-25",
            Rating = 80
        };
    }
}