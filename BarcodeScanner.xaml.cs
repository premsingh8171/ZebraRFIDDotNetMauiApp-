using Com.Zebra.Rfid.Api3;

namespace ZebraRFIDDotNetMauiApp;

public partial class BarcodeScanner : ContentPage
{
    private RFIDReader reader;
#pragma warning disable CS0169 // The field 'BarcodeScanner.readers' is never used
    private static Readers? readers;
#pragma warning restore CS0169 // The field 'BarcodeScanner.readers' is never used


    public BarcodeScanner()
    {
        InitializeComponent();
        InitializeBarcodeScanner();
    }

    private void InitializeBarcodeScanner()
    {
        // Initialize and configure the RFID reader
        reader = new RFIDReader();
        reader.Connect();
        reader.Events.EventReadNotify += OnReadNotify;
        reader.Events.EventStatusNotify += OnStatusNotify;
        reader.Actions.Inventory.Perform();
    }

    [Obsolete]
    private void OnReadNotify(object? sender, EventReadNotifyEventArgs e)
    {

        // Handle barcode read event
        var tagData = e.P0;
        string barcodeValue = BitConverter.ToString((byte[])tagData).Replace("-", "");
        Device.BeginInvokeOnMainThread(() =>
        {
            // Update UI with the scanned barcode value
            DisplayAlert("Barcode Scanned", $"Value: {barcodeValue}", "OK");
        });
    }

    private void OnStatusNotify(object? sender, EventStatusNotifyEventArgs e)
    {
        // Handle status change events
        var statusData = e.Equals;
        // var statusData = e.StatusEventData.StatusData;
        // Add your logic to handle status changes (e.g., reader disconnected)
    }




    private void OnStartScanningClicked(object sender, EventArgs e)
    {
        // Start or resume the scanning process
        reader.Actions.Inventory.Perform();
    }
}
