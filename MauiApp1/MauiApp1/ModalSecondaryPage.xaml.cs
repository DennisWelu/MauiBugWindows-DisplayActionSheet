namespace MauiApp1;

public partial class ModalSecondaryPage : ContentPage
{
	public ModalSecondaryPage()
	{
		InitializeComponent();
	}

	void OnGoBackClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}