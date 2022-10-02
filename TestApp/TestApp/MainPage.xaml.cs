namespace TestApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnBtnClicked(object sender, EventArgs e) {
        FilePickerFileType gpxFileType = new(
                new Dictionary<DevicePlatform, IEnumerable<string>> {
                    {DevicePlatform.Android, new[] { "application/gpx+xml", "application/gpx", "text/xml" } },
                    {DevicePlatform.WinUI, new[] { ".gpx" } },
                }
                );

        PickOptions options = new() {
            PickerTitle = "Select a gpx file",
            FileTypes = gpxFileType,
        };

        FileResult result = await FilePicker.PickAsync(options);

        showResult.Text = result.FileName;
    }
}

