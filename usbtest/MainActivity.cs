using Android.App;
using Android.Widget;
using Android.OS;
using Android.Hardware.Usb;
using Android.Content;
using System.Linq;

using tsclib;
using System.Text;
using System;
using Java.IO;
using Android.Support.V4.Content;
using Android;
using Android.Content.PM;
using System.Threading;

namespace usbtest
{
    [Activity(Label = "usbtest", MainLauncher = true, Icon = "@drawable/icon")]

    //[BroadcastReceiver(Enabled = true)]
    //[IntentFilter(new[] { UsbManager.ActionUsbDeviceAttached, UsbManager.ActionUsbDeviceDetached })]
    //[MetaData(UsbManager.ActionUsbDeviceAttached, Resource = "@xml/device_filter")]
    //[MetaData(UsbManager.ActionUsbDeviceDetached, Resource = "@xml/device_filter")]


    public class MainActivity : Activity
    {
        private static string ACTION_USB_PERMISSION = "com.tscprinters.android";
        private Button button1;
        private TextView tv1;

        private static UsbManager mUsbManager;
        private static UsbDevice mUsbDevice;
        private static PendingIntent mPermissionIntent;
        public string DownloadsPath { get; set; }
        public string PCXPath { get; set; }

        tsclib.usb usb = new tsclib.usb();

        protected override void OnCreate(Bundle bundle)
        {
            try
            {
                base.OnCreate(bundle);
                // Set our view from the "main" layout resource
                SetContentView(Resource.Layout.Main);

                mUsbManager = (UsbManager)this.GetSystemService(Context.UsbService);
                var matchingDevice = mUsbManager.DeviceList.FirstOrDefault(item => item.Value.VendorId == 4611 || item.Value.ProductId == 37022);
                var usbPort = matchingDevice.Key;
                mUsbDevice = matchingDevice.Value;
                mPermissionIntent = PendingIntent.GetBroadcast(this, 0, new Intent(ACTION_USB_PERMISSION), 0);
                mUsbManager.RequestPermission(mUsbDevice, mPermissionIntent);

                tv1 = FindViewById<TextView>(Resource.Id.textView1);
                button1 = FindViewById<Button>(Resource.Id.button1);
                button1.Click += delegate { send(); };
            }
            catch (System.Exception)
            {

                //throw;
            }
            var DownloadsPath = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).AbsolutePath.ToString();

            Java.IO.File directory = new Java.IO.File(DownloadsPath);
            Java.IO.File[] files = directory.ListFiles();//always count is 0 even though there are lot files there

            var fileList = new StringBuilder();
            foreach (var i in files)
            {
                //FileInfo info = new FileInfo(i.Name);
                //if (info.Name.Contains("Wall_e"))
                //{
                //    di.Add(new DownloadedImages { Path1 = info.DirectoryName, Name1 = info.FullName });
                //}
                fileList.AppendLine(i.AbsolutePath);
                if (i.Name.ToLower().Contains("pcx"))
                {
                    PCXPath = i.AbsolutePath;
                }
            }


            var outputString = DownloadsPath;
            outputString += hasReadPermissions() ? " / YesRead" : " / NoRead";
            outputString += hasWritePermissions() ? " / YesWrite" : " / NoWrite";
            outputString += System.Environment.NewLine + fileList.ToString();
            FindViewById<TextView>(Resource.Id.textView1).Text = outputString;


        }

        private bool hasReadPermissions()
        {
            return (ContextCompat.CheckSelfPermission(this, Manifest.Permission.ReadExternalStorage) == Permission.Granted);
        }

        private bool hasWritePermissions()
        {
            return (ContextCompat.CheckSelfPermission(this, Manifest.Permission.WriteExternalStorage) == Permission.Granted);
        }


        private void send()
        {
            try
            {
                usb.openport(mUsbManager, mUsbDevice);
            }
            catch (Exception ex)
            {
                tv1.Text = ex.Message;
            }

            usb.sendcommand("SIZE 108 mm, 520 mm\r\n");
            usb.sendcommand("SPEED 4\r\n");
            usb.sendcommand("DENSITY 12\r\n");
            usb.sendcommand("OFFSET -2\r\n");
            usb.sendcommand("DIRECTION 0\r\n");
            usb.sendcommand("SET TEAR ON\r\n");
            usb.sendcommand("SET RIBBON ON\r\n");
            usb.sendcommand("CODEPAGE UTF-8\r\n");
            usb.sendcommand("SET GAP 0\r\n");
            usb.sendcommand("SET CUTTER OFF\r\n");
            usb.sendcommand("SET PEEL OFF\r\n");
            usb.sendcommand("REFERENCE 0, 0\r\n");

            usb.clearbuffer();

            //Tells it to download a file to flash, with the name PRINTREG.BAS. All the following commands until EOP are lines written to the file.
            usb.sendcommand("DOWNLOAD F, \"PRINTREG.BAS\"\r\n");

            //LOADMAT Sets LEDs and Key to be configurable.
            usb.sendcommand(":LOADMAT\r\n");
            usb.sendcommand("SET KEY1 OFF\r\n");
            usb.sendcommand("SET LED1 OFF\r\n");
            usb.sendcommand("SET LED3 OFF\r\n");

            //CHKKEY - Initial feed of 170. Flash LED until button pressed then call REFEED.
            usb.sendcommand(":CHKKEY\r\n");

            usb.sendcommand("LED1 = 0\r\n");
            usb.sendcommand("LED3 = 0\r\n");

            usb.sendcommand("FOR I = 1 TO 250\r\n");
            usb.sendcommand("REM\r\n");
            usb.sendcommand("NEXT I\r\n");

            usb.sendcommand("LED3 = 1\r\n");

            usb.sendcommand("FOR I = 1 TO 250\r\n");
            usb.sendcommand("REM\r\n");
            usb.sendcommand("NEXT I\r\n");

            usb.sendcommand("IF KEY1 = 1 THEN\r\n");
            usb.sendcommand("FEED 100\r\n");
            usb.sendcommand("GOTO REFEED\r\n");
            usb.sendcommand("ELSE\r\n");
            usb.sendcommand("GOTO CHKKEY\r\n");
            usb.sendcommand("ENDIF\r\n");

            //REFEED - Turn LED solid red and incremental feed until sensor is triggered then go to SETUP.
            usb.sendcommand(":REFEED\r\n");
            usb.sendcommand("LED1 = 0\r\n");
            usb.sendcommand("IF PEEL = 0 THEN\r\n");
            usb.sendcommand("LED3 = 1\r\n");
            usb.sendcommand("FEED 1\r\n");
            usb.sendcommand("GOTO REFEED\r\n");
            usb.sendcommand("ELSE\r\n");
            usb.sendcommand("GOTO SETUP\r\n");
            usb.sendcommand("ENDIF\r\n");

            //SETUP - Turn LED green and backfeed 160.
            usb.sendcommand(":SETUP\r\n");
            usb.sendcommand("LED3 = 0\r\n");
            usb.sendcommand("LED1 = 1\r\n");
            usb.sendcommand("BACKFEED 160\r\n");
            usb.sendcommand("EOP\r\n");

            ////This calls the PRINTREG.BAS file that is downloaded above.
            usb.sendcommand("PRINTREG\r\n");
            usb.sendcommand("CLS\r\n");

            try
            {
                byte[] data = System.IO.File.ReadAllBytes(PCXPath);
                FindViewById<TextView>(Resource.Id.textView1).Text += System.Environment.NewLine + "Convert File to Bytes";
                string download = "DOWNLOAD F, \"" + "PLATE.PCX" + "\"," + data.Length + ",";
                FindViewById<TextView>(Resource.Id.textView1).Text += System.Environment.NewLine + "Build download command";
                //byte[] download_foot = Encoding.ASCII.GetBytes(System.Environment.NewLine);
                byte[] download_head = Encoding.UTF8.GetBytes(download);
                FindViewById<TextView>(Resource.Id.textView1).Text += System.Environment.NewLine + "Convert Download Command to Byte";

                usb.sendcommand(download_head.Concat(data).ToArray());
                FindViewById<TextView>(Resource.Id.textView1).Text += System.Environment.NewLine + "Send Head and Data Bytes in Command";

                usb.sendcommand(Encoding.UTF8.GetBytes(System.Environment.NewLine));

                FindViewById<TextView>(Resource.Id.textView1).Text += System.Environment.NewLine + "Send NewLine as Bytes";

            }
            catch (Exception ex)
            {
                FindViewById<TextView>(Resource.Id.textView1).Text = ex.Message;
            }
            usb.sendcommand("CLS\r\n");

            FindViewById<TextView>(Resource.Id.textView1).Text += System.Environment.NewLine + "Send CLS";
            //usb.sendcommand("CLS\r\n");
            ////Puts the PLATE.PCX into the buffer.
            //usb.sendcommand("PUTPCX 15,15,\"PLATE.PCX\"\r\n");

            //var filepathtext = "TEXT 100,100,\"3\",0,1,1,\"" + PCXPath.ToString() + "\"\r\n";
            //usb.sendcommand(filepathtext.ToString());

            //usb.printlabel(1, 1);
            usb.closeport();

        }



    }
}

