namespace ZebraRFIDDotNetMauiApp
{
    public partial class MainPage : ContentPage
    {
        //// Class members
        //private static Readers? readers;
        //private static IList? availableRFIDReaderList;
        //private static ReaderDevice? readerDevice;
        //private static RFIDReader Reader;
        //private EventHandler eventHandler;
        //private string _status;

        //// Property for Status
        //public string Status { get => _status; set { _status = value; OnPropertyChanged(); } }

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //BindingContext = this;
            //// SDK initialization
            //if (readers == null)
            //{
            //    readers = new Readers(Android.App.Application.Context, ENUM_TRANSPORT.ServiceSerial);
            //}

            //// Get available RFID readers
            //GetAvailableReaders();
        }

        //// Method to get available RFID readers
        //private void GetAvailableReaders()
        //{
        //    ThreadPool.QueueUserWorkItem(o =>
        //    {
        //        try
        //        {
        //            if (readers != null && readers.AvailableRFIDReaderList != null)
        //            {
        //                availableRFIDReaderList = (IList?)readers.AvailableRFIDReaderList;
        //                if (availableRFIDReaderList?.Count > 0)
        //                {
        //                    if (Reader == null)
        //                    {
        //                        // Get the first reader from the list
        //                        readerDevice = (ReaderDevice?)availableRFIDReaderList[0];
        //                        Reader = readerDevice?.RFIDReader;

        //                        // Establish connection to the RFID reader
        //                        Reader.Connect();
        //                        if (Reader.IsConnected)
        //                        {
        //                            Console.Out.WriteLine("Reader connected");
        //                            Status = "Reader connected";
        //                            ConfigureReader();
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        catch (InvalidUsageException e)
        //        {
        //            e.PrintStackTrace();
        //        }
        //        catch (OperationFailureException e)
        //        {
        //            e.PrintStackTrace();
        //            Console.Out.WriteLine("OperationFailureException " + e.VendorMessage);
        //            Status = "OperationFailureException " + e.VendorMessage;
        //        }
        //    });
        //}

        //// Method to configure the RFID reader
        //private void ConfigureReader()
        //{
        //    if (Reader.IsConnected)
        //    {
        //        TriggerInfo triggerInfo = new TriggerInfo();
        //        triggerInfo.StartTrigger.TriggerType = START_TRIGGER_TYPE.StartTriggerTypeImmediate;
        //        triggerInfo.StopTrigger.TriggerType = STOP_TRIGGER_TYPE.StopTriggerTypeImmediate;
        //        try
        //        {
        //            // Receive events from the reader
        //            if (eventHandler == null)
        //            {
        //                eventHandler = new EventHandler(Reader);
        //            }

        //            Reader.Events.AddEventsListener(eventHandler);

        //            // HH event
        //            Reader.Events.SetHandheldEvent(true);
        //            // Tag event with tag data
        //            Reader.Events.SetTagReadEvent(true);
        //            Reader.Events.SetAttachTagDataWithReadEvent(false);

        //            // Set trigger mode as RFID so the scanner beam will not come
        //            Reader.Config.SetTriggerMode(ENUM_TRIGGER_MODE.RfidMode, true);

        //            // Set start and stop triggers
        //            Reader.Config.StartTrigger = triggerInfo.StartTrigger;
        //            Reader.Config.StopTrigger = triggerInfo.StopTrigger;
        //        }
        //        catch (InvalidUsageException e)
        //        {
        //            e.PrintStackTrace();
        //        }
        //        catch (OperationFailureException e)
        //        {
        //            e.PrintStackTrace();
        //        }
        //    }
        //}

        //// Read/Status Notify handler
        //// Implement the RfidEventsLister class to receive event notifications
        //public class EventHandler : Java.Lang.Object, IRfidEventsListener
        //{
        //    public EventHandler(RFIDReader Reader)
        //    {

        //    }

        //    // Read Event Notification
        //    public void EventReadNotify(RfidReadEvents e)
        //    {
        //        TagData[] myTags = Reader.Actions.GetReadTags(100);
        //        if (myTags != null)
        //        {
        //            for (int index = 0; index < myTags.Length; index++)
        //            {
        //                Console.Out.WriteLine("Tag ID " + myTags[index].TagID);
        //                if (myTags[index].OpCode == ACCESS_OPERATION_CODE.AccessOperationRead &&
        //                    myTags[index].OpStatus == ACCESS_OPERATION_STATUS.AccessSuccess)
        //                {
        //                    if (myTags[index].MemoryBankData.Length > 0)
        //                    {
        //                        Console.Out.WriteLine(" Mem Bank Data " + myTags[index].MemoryBankData);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    // Status Event Notification
        //    public void EventStatusNotify(RfidStatusEvents rfidStatusEvents)
        //    {
        //        Console.Out.WriteLine("Status Notification: " + rfidStatusEvents.StatusEventData.StatusEventType);
        //        if (rfidStatusEvents.StatusEventData.StatusEventType == STATUS_EVENT_TYPE.HandheldTriggerEvent)
        //        {
        //            if (rfidStatusEvents.StatusEventData.HandheldTriggerEventData.HandheldEvent ==
        //                    HANDHELD_TRIGGER_EVENT_TYPE.HandheldTriggerPressed)
        //            {
        //                ThreadPool.QueueUserWorkItem(o =>
        //                {
        //                    try
        //                    {
        //                        Reader.Actions.Inventory.Perform();
        //                    }
        //                    catch (InvalidUsageException e)
        //                    {
        //                        e.PrintStackTrace();
        //                    }
        //                    catch (OperationFailureException e)
        //                    {
        //                        e.PrintStackTrace();
        //                    }
        //                });
        //            }
        //            if (rfidStatusEvents.StatusEventData.HandheldTriggerEventData.HandheldEvent ==
        //                    HANDHELD_TRIGGER_EVENT_TYPE.HandheldTriggerReleased)
        //            {
        //                ThreadPool.QueueUserWorkItem(o =>
        //                {
        //                    try
        //                    {
        //                        Reader.Actions.Inventory.Stop();
        //                    }
        //                    catch (InvalidUsageException e)
        //                    {
        //                        e.PrintStackTrace();
        //                    }
        //                    catch (OperationFailureException e)
        //                    {
        //                        e.PrintStackTrace();
        //                    }
        //                });
        //            }
        //        }
        //    }
        //}
    }

}
