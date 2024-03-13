namespace BMICalculator.MVVM.Views;

public partial class StartView : ContentPage
{
	public StartView()
	{
		InitializeComponent();
	}

	private void Button_Clicked(Object sender, EventArgs e)
	{
		Navigation.PushAsync(new BMIUSView());
	}

    private void Button_Clicked1(Object sender, EventArgs e)
    {
        Navigation.PushAsync(new BMIView());
    }
}