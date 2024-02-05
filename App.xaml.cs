namespace ZebraRFIDDotNetMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BarcodeScanner();
        }
    }
}
