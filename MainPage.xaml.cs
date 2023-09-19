namespace ArrowKeyTest;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }


    private static void AllowArrowKeyNavigation(IView layoutElement)
    {
#if WINDOWS
        if (layoutElement.Handler?.PlatformView is Microsoft.UI.Xaml.FrameworkElement element)
        {
            element.TabFocusNavigation = Microsoft.UI.Xaml.Input.KeyboardNavigationMode.Once;
            element.XYFocusKeyboardNavigation = Microsoft.UI.Xaml.Input.XYFocusKeyboardNavigationMode.Enabled;
        }
#endif
    }

    private void MainPage_OnLoaded(object? sender, EventArgs e)
    {
        AllowArrowKeyNavigation(CheckBoxes);
        AllowArrowKeyNavigation(RadioButtons);
    }
}