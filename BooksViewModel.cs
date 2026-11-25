using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LibraryCollege.Commands;
using LibraryCollege.Models;

namespace LibraryCollege;

public class BooksViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Book> Books { get; } = new();

    private Book? _selectedBook;
    public Book? SelectedBook
    {
        get => _selectedBook;
        set { _selectedBook = value; OnPropertyChanged(); }
    }

    private string _newTitle = "";
    public string NewTitle
    {
        get => _newTitle;
        set { _newTitle = value; OnPropertyChanged(); }
    }

    private string _newAuthor = "";
    public string NewAuthor
    {
        get => _newAuthor;
        set { _newAuthor = value; OnPropertyChanged(); }
    }

    public ICommand AddCommand { get; }
    public ICommand DeleteCommand { get; }
    public ICommand ClearCommand { get; }

    public BooksViewModel()
    {
        Books.Add(new Book { Title = "Война и мир", Author = "Л. Н. Толстой", Year = 1869 });
        Books.Add(new Book { Title = "Мастер и Маргарита", Author = "М. А. Булгаков", Year = 1967 });

        AddCommand = new RelayCommand(_ => AddBook(), _ => !string.IsNullOrWhiteSpace(NewTitle));
        DeleteCommand = new RelayCommand(p => DeleteBook(p as Book), p => p is Book);
        ClearCommand = new RelayCommand(_ => Books.Clear(), _ => Books.Count > 0);
    }

    private void AddBook()
    {
        Books.Add(new Book { Title = NewTitle.Trim(), Author = NewAuthor.Trim() });
        NewTitle = "";
        NewAuthor = "";
    }

    private void DeleteBook(Book? book)
    {
        if (book != null) Books.Remove(book);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}