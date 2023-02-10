#if ANDROID
using NativeAutoCompleteView = AndroidX.AppCompat.Widget.AppCompatAutoCompleteTextView;
#endif
#if IOS
using NativeAutoCompleteView = Maui.FreakyControls.Platforms.iOS.AutoCompleteUiTextField;
#endif

using Microsoft.Maui.Handlers;

namespace Maui.FreakyControls;

#if ANDROID || IOS
public partial class AutoCompleteViewHandler : ViewHandler<AutoCompleteView, NativeAutoCompleteView>
{
    public static PropertyMapper<AutoCompleteView, AutoCompleteViewHandler> Mapper =
            new(ViewHandler.ViewMapper)
            {
                [nameof(AutoCompleteView.ItemsSource)] = MapItemsSource,
                [nameof(AutoCompleteView.Text)] = MapText,
                //[nameof(AutoCompleteView.)]
            };

  
    public static CommandMapper<AutoCompleteView, AutoCompleteViewHandler> CommandMapper =
        new(ViewHandler.ViewCommandMapper)
        {
        };

    public AutoCompleteViewHandler() : base(Mapper)
    {
    }

    public AutoCompleteViewHandler(IPropertyMapper? mapper)
        : base(mapper ?? Mapper, CommandMapper)
    {
    }

    public AutoCompleteViewHandler(IPropertyMapper? mapper, CommandMapper? commandMapper)
        : base(mapper ?? Mapper, commandMapper ?? CommandMapper)
    {
    }

    private static void MapItemsSource(AutoCompleteViewHandler handler, AutoCompleteView view)
    {
        handler.UpdateItemsSource();
    }

    private static void MapText(AutoCompleteViewHandler handler, AutoCompleteView view)
    {
        handler.PlatformView.Text = handler.VirtualView?.Text;
    }

}
#elif MACCATALYST

public partial class AutoCompleteViewHandler : ViewHandler<AutoCompleteView, UIKit.UIView>
{
    public AutoCompleteViewHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
    {
    }

    protected override UIKit.UIView CreatePlatformView()
    {
        return new UIKit.UIView();
    }
}

#endif