using AndroidSpecific = Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace tabbar_repro;

public partial class MainPage : TabbedPage
{
	public MainPage()
	{
        var ColorBackground = Color.FromArgb("#FFFFFFFF");
        var ColorOnBackground = Color.FromArgb("#FF222426");

        BarBackgroundColor = Colors.Red;
        SelectedTabColor = Colors.White;
        UnselectedTabColor = ColorOnBackground;

        AndroidSpecific.TabbedPage.SetToolbarPlacement(this, AndroidSpecific.ToolbarPlacement.Bottom);

		Children.Add(new ContentPage { Title = "Home", BackgroundColor = ColorBackground, IconImageSource = ImageSource.FromFile("ico_home")});
		Children.Add(new ContentPage { Title = "Messages", BackgroundColor = ColorBackground, IconImageSource = ImageSource.FromFile("ico_calendar")});
		Children.Add(new ContentPage { Title = "More", BackgroundColor = ColorBackground, IconImageSource = ImageSource.FromFile("ico_more")});
	}
}

