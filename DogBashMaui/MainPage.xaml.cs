namespace Dog_Bash_Maui;

public partial class MainPage : ContentPage
{
	bool locationSharing = false;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		if (locationSharing == false)
		{
			locationSharing = true;
			LocationSharingBtn.Text = "Stop Sharing";

        }

		else
		{
			locationSharing = false;
            LocationSharingBtn.Text = "Share Location";
        }

        SemanticScreenReader.Announce(LocationSharingBtn.Text);
	}
}

