namespace Samples.InputViews;

public partial class InputViews : ContentPage
{
    public InputViews()
    {
        try
        {
            InitializeComponent();
            this.BindingContext = new InputViewModel();
        }
        catch (Exception ex)
        {

        }
    }
}