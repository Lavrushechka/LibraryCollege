using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryCollege.Commands;
using LibraryCollege.Models;

namespace LibraryCollege.ViewModels;

public class BooksViewModel : ViewModelBase
{
    public ObservableCollection<Book> Books { get; } = new();

    private Book? _selectedBook;
    public Book? SelectedBook
    {
        get => _selectedBook;
        set => Set(ref _selectedBook, value);
    }

    private string _newTitle = "";
    public string NewTitle { get => _newTitle; set => Set(ref _newTitle, value); }

    private string _newAuthor = "";
    public string NewAuthor { get => _newAuthor; set => Set(ref _newAuthor, value); }

    public ICommand AddCommand { get; }
    public ICommand DeleteCommand { get; }

    public BooksViewModel()
    {
        Books.Add(new Book { Title = "Война и мир", Author = "Л. Н. Толстой", Year = 1869 });
        Books.Add(new Book { Title = "Мастер и Маргарита", Author = "М. А. Булгаков", Year = 1967 });

        AddCommand = new RelayCommand(_ => Books.Add(new Book
        {
            Title = NewTitle,
            Author = NewAuthor
        }), _ => !string.IsNullOrWhiteSpace(NewTitle));

        DeleteCommand = new RelayCommand(
            _ => { if (SelectedBook != null) Books.Remove(SelectedBook); },
            _ => SelectedBook != null);
    }
}