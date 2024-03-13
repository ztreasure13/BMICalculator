using BMICalculator.MVVM.ViewModels;

namespace BMICalculator.MVVM.Views;

public partial class BMIUSView : ContentPage
{
	public BMIUSView()
	{
		InitializeComponent();
        BindingContext = new BMIUSViewModel();
    }
}