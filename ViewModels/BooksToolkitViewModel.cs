using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LibraryCollege.Models;

namespace LibraryCollege.ViewModels;

public partial class BooksToolkitViewModel : ObservableObject
{
    public ObservableCollection<Book> Books { get; } = new();

    [ObservableProperty]
    private Book? selectedBook;

    [ObservableProperty]
    private string newTitle = "";

    [ObservableProperty]
    private string newAuthor = "";

    public BooksToolkitViewModel()
    {
        Books.Add(new Book { Title = "Война и мир", Author = "Л. Н. Толстой", Year = 1869 });
        Books.Add(new Book { Title = "Мастер и Маргарита", Author = "М. А. Булгаков", Year = 1967 });
    }

    [RelayCommand]
    private void AddBook()
    {
        if (string.IsNullOrWhiteSpace(NewTitle)) return;

        Books.Add(new Book { Title = NewTitle.Trim(), Author = NewAuthor.Trim() });
        NewTitle = "";
        NewAuthor = "";
    }

    [RelayCommand]
    private void DeleteBook()
    {
        if (SelectedBook != null)
            Books.Remove(SelectedBook);
    }
}