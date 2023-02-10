using System;
using Android.Widget;
using AndroidX.AppCompat.Widget;

namespace Maui.FreakyControls;

public partial class AutoCompleteViewHandler
{
    protected override AppCompatAutoCompleteTextView CreatePlatformView()
    {
        var autoCompleteTextView = new AppCompatAutoCompleteTextView(Context);
        autoCompleteTextView.Threshold = 1;
        //autoCompleteTextView.ItemClick += (s, a) =>
        //{
        //    autoCompleteView.SelectedItem = autoCompleteTextView.Text;
        //};

        return autoCompleteTextView;
    }

    public void UpdateItemsSource()
    {
        var listItems = VirtualView.ItemsSource.ToList();
        PlatformView.Adapter = new ArrayAdapter(
            this.Context,
            Android.Resource.Layout.SimpleDropDownItem1Line,
            listItems);
    }


}

