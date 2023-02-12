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

    public List<CounrryModel> Countries { get; }

    public InputViewModel()
    {
        var countryProvider = new CountryProvider();
        var countries = countryProvider.GetCountries().Select(x => new CounrryModel
        {
            Name = x.OfficialName,
            CountryCode = x.NumericCode
        });
        Countries = new List<CounrryModel>(countries);
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

public class CounrryModel
{
    public string Name { get; set; }

    public int CountryCode { get; set; }
}