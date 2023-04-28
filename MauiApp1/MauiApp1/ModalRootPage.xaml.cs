using System.Diagnostics;

namespace MauiApp1;

public partial class ModalRootPage : ContentPage
{
	public ModalRootPage()
	{
		InitializeComponent();
	}

	void OnGoForwardClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ModalSecondaryPage());
	}

	void OnCloseClicked(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}

	async void OnDisplayActionSheetClicked(object sender, EventArgs e)
	{
		var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
		Debug.WriteLine("Action: " + action);
	}

}