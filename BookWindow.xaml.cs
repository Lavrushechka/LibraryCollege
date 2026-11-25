using System.Collections.ObjectModel;
using System.Windows;
using LibraryCollege.Models;

namespace LibraryCollege;

public partial class BookWindow : Window
{
    private readonly ObservableCollection<Book> _books = new();

    public BookWindow()
    {
        InitializeComponent();
        GridBooks.ItemsSource = _books;
    }

    private void BtnAdd_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtTitle.Text)) return;

        _books.Add(new Book
        {
            Title = TxtTitle.Text,
            Author = TxtAuthor.Text,
            Year = DpYear.SelectedDate?.Year
        });

        TxtTitle.Clear();
        TxtAuthor.Clear();
        DpYear.SelectedDate = null;
    }

    private void BtnDelete_Click(object sender, RoutedEventArgs e)
    {
        if (GridBooks.SelectedItem is Book selected)
            _books.Remove(selected);
    }
}