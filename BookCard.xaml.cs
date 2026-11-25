using System.Windows;
using System.Windows.Controls;

namespace LibraryCollege;

public partial class BookCard : UserControl
{
    public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register(nameof(Title), typeof(string), typeof(BookCard),
            new PropertyMetadata("Без названия"));

    public static readonly DependencyProperty AuthorProperty =
        DependencyProperty.Register(nameof(Author), typeof(string), typeof(BookCard),
            new PropertyMetadata("Неизвестный автор"));

    public static readonly DependencyProperty YearProperty =
        DependencyProperty.Register(nameof(Year), typeof(int), typeof(BookCard),
            new PropertyMetadata(0));

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Author
    {
        get => (string)GetValue(AuthorProperty);
        set => SetValue(AuthorProperty, value);
    }

    public int Year
    {
        get => (int)GetValue(YearProperty);
        set => SetValue(YearProperty, value);
    }

    public BookCard()
    {
        InitializeComponent();
    }
}