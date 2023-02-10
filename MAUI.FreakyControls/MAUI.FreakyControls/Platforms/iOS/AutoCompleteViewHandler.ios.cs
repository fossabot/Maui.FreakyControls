using Maui.FreakyControls.Platforms.iOS;
using UIKit;

namespace Maui.FreakyControls;

public partial class AutoCompleteViewHandler
{
    protected override AutoCompleteUiTextField CreatePlatformView()
    {
        var autocompleteView=  new AutoCompleteUiTextField();
        autocompleteView.SuggestionsUITableView.BackgroundColor = UIColor.White;
        return autocompleteView;
    }

    public void UpdateItemsSource()
    {
        PlatformView.Suggestions = VirtualView?.ItemsSource;
    }
}

