using System.Collections.ObjectModel;
using System.Windows.Input;
using Nager.Country;

namespace Samples.InputViews;

public class InputViewModel : MainViewModel
{
    private string _searchCountry = string.Empty;
    private bool _customSearchFunctionSwitchIsToggled;

    public string SearchCountry
    {
        get => _searchCountry;
        set
        {
            _searchCountry = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<string> Countries { get; }

    private string selectedFruit;
    public string SelectedFruit
    {
        get => selectedFruit;
        set
        {
            selectedFruit = value;
            OnPropertyChanged();
        }
    }

    public List<string> FruitSuggestions { get; set; }

    public ICommand SelectFruitCommand { get; set; }

    public InputViewModel()
    {
        var countryProvider = new CountryProvider();
        var countries = countryProvider.GetCountries().Select(x => x.OfficialName);
        Countries = new ObservableCollection<string>(countries);

        FruitSuggestions = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Date",
            "Elderberry",
            "Fig",
            "Grape",
            "Honeydew",
            "Iced Melon"
        };

        SelectFruitCommand = new Command<string>(fruit =>
        {
            SelectedFruit = fruit;
        });
    }

    public bool CustomSearchFunctionSwitchIsToggled
    {
        get => _customSearchFunctionSwitchIsToggled;
        set
        {
            _customSearchFunctionSwitchIsToggled = value;
            OnPropertyChanged();
        }
    }
}