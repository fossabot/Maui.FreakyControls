using System.Collections;

namespace Maui.FreakyControls;
public class AutoCompleteView : View
{
    public static readonly BindableProperty ItemsSourceProperty =
        BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable), typeof(AutoCompleteView), default(IEnumerable<string>));

    public IEnumerable<string> ItemsSource
    {
        get { return (IEnumerable<string>)GetValue(ItemsSourceProperty); }
        set { SetValue(ItemsSourceProperty, value); }
    }

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(AutoCompleteView), default(string));

    public string Text
    {
        get { return (string)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }

    //public static readonly BindableProperty BackgroundColorProperty =
    //   BindableProperty.Create(nameof(Text), typeof(string), typeof(AutoCompleteView), default(string));

    //public string Text
    //{
    //    get { return (string)GetValue(TextProperty); }
    //    set { SetValue(TextProperty, value); }
    //}

    public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

    public void NotifyItemSelected(object selectedItem, int selectedIndex)
    {
        ItemSelected?.Invoke(this, new SelectedItemChangedEventArgs(selectedItem, selectedIndex));
    }
}
