using System.ComponentModel;

public class CVViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private string _name;
    private string _occupation;
    private string _phone;
    private string _email;
    private string _location;
    private string _linkedIn;
    private string _professionalProfile;
    private string _englishLevel;
    private string _frenchLevel;

    public string Name
    {
        get { return _name; }
        set { _name = value; OnPropertyChanged(nameof(Name)); }
    }

    public string Occupation
    {
        get { return _occupation; }
        set { _occupation = value; OnPropertyChanged(nameof(Occupation)); }
    }

    public string Phone
    {
        get { return _phone; }
        set { _phone = value; OnPropertyChanged(nameof(Phone)); }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; OnPropertyChanged(nameof(Email)); }
    }

    public string Location
    {
        get { return _location; }
        set { _location = value; OnPropertyChanged(nameof(Location)); }
    }

    public string LinkedIn
    {
        get { return _linkedIn; }
        set { _linkedIn = value; OnPropertyChanged(nameof(LinkedIn)); }
    }

    public string ProfessionalProfile
    {
        get { return _professionalProfile; }
        set { _professionalProfile = value; OnPropertyChanged(nameof(ProfessionalProfile)); }
    }

    public string EnglishLevel
    {
        get { return _englishLevel; }
        set { _englishLevel = value; OnPropertyChanged(nameof(EnglishLevel)); }
    }

    public string FrenchLevel
    {
        get { return _frenchLevel; }
        set { _frenchLevel = value; OnPropertyChanged(nameof(FrenchLevel)); }
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

