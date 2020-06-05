using Android.App;
using Android.Widget;
using Android.OS;
using Android.Hardware.Usb;
using Android.Content;
using System.Linq;
using System.Text;
using System;
using Java.IO;
using Android.Support.V4.Content;
using Android;
using Android.Content.PM;
using System.Threading;
using Com.Godex;
using System.IO;
using Android.Content.Res;
using Android.Graphics;

namespace usbtest
{
    [Activity(Label = "usbtest", MainLauncher = true, Icon = "@drawable/icon")]

    //[BroadcastReceiver(Enabled = true)]
    //[IntentFilter(new[] { UsbManager.ActionUsbDeviceAttached, UsbManager.ActionUsbDeviceDetached })]
    //[MetaData(UsbManager.ActionUsbDeviceAttached, Resource = "@xml/device_filter")]
    //[MetaData(UsbManager.ActionUsbDeviceDetached, Resource = "@xml/device_filter")]


    public class MainActivity : Activity
    {
        private static string ACTION_USB_PERMISSION = "com.godexintl.android";
        private Button button1;
        private TextView tv1;

        private static UsbManager mUsbManager;
        private static UsbDevice mUsbDevice;
        private static PendingIntent mPermissionIntent;
        public string DownloadsPath { get; set; }
        public string PCXPath { get; set; }

     

        
        protected override void OnCreate(Bundle bundle)
        {
            try
            {
                base.OnCreate(bundle);
                // Set our view from the "main" layout resource
                SetContentView(Resource.Layout.Main);

                mUsbManager = (UsbManager)this.GetSystemService(Context.UsbService);
                var matchingDevice = mUsbManager.DeviceList.FirstOrDefault(item => item.Value.VendorId == 6495 || item.Value.ProductId == 1);
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
            Godex.GetMainContext(Android.App.Application.Context);

            if (Godex.Openport(null, 3))
            {
                try
                {
                    Stream bitmap;
                    AssetManager assets = Android.App.Application.Context.Assets;
                    bitmap = assets.Open("plate.jpg");
                    Bitmap image = BitmapFactory.DecodeStream(bitmap);

                    Godex.Setup("520", "8", "2", "1", "3", "0");
                    Godex.SendCommand("^L");
                    Godex.PutImage(20, 100, image);
                    Godex.SendCommand("E");

                    //var downloadPath = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads);
                    bitmap.Dispose();
                    image.Dispose();

                }
                catch (Exception ex)
                {

                }

            }

        }

        private static byte[] GetBytesFromImage(string imagePath)
        {
            var imgFile = new Java.IO.File(imagePath);
            var stream = new FileInputStream(imgFile);
            var bytes = new byte[imgFile.Length()];
            stream.Read(bytes);
            return bytes;
        }

    }
}

