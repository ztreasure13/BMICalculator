using BMICalculator.MVVM.Views;

namespace BMICalculator
{
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF5cWWJCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXxfc3VWQ2dYVkJ/V0U=");

            InitializeComponent();

            MainPage = new NavigationPage(new StartView());
        }
    }
}
