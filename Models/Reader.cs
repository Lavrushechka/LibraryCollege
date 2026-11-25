using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibraryCollege.Models;

public class Reader : INotifyPropertyChanged
{
    private string _fullName = "";
    public string FullName
    {
        get => _fullName;
        set { _fullName = value; OnPropertyChanged(); }
    }

    private string _group = "";
    public string Group
    {
        get => _group;
        set { _group = value; OnPropertyChanged(); }
    }

    private bool _isActive = true;
    public bool IsActive
    {
        get => _isActive;
        set { _isActive = value; OnPropertyChanged(); }
    }

    private int _rating = 50;
    public int Rating
    {
        get => _rating;
        set { _rating = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}