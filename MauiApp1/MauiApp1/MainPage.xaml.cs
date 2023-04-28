using System.Diagnostics;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void OnOpenModalClicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new NavigationPage(new ModalRootPage()));
	}

	async void OnDisplayActionSheetClicked(object sender, EventArgs e)
	{
		var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
		Debug.WriteLine("Action: " + action);
	}
}

