using System.ComponentModel;

namespace HW_11_11_2024;

public class Meter : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    string manufacturer;
    public string Manufacturer
    {
        get => manufacturer;
        set
        {
            manufacturer = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Manufacturer)));
        }
    }

    int id;
    public int ID
    {
        get => id;
        set
        {
            id = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ID)));
        }
    }

    DateTime date;
    public DateTime Date
    {
        get => date;
        set
        {
            date = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Date)));
        }
    }

    bool isHot;
    public bool IsHot
    {
        get => isHot;
        set
        {
            isHot = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsHot)));
        }
    }
}
