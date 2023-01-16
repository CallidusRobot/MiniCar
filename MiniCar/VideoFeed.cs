using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;

namespace MiniCar
{
    public partial class VideoFeed : UserControl
    {
        private string cameraBaseAddress = "";
        private string feedAddress = "";
        private string resolutionUpgradeAddress = "";

        private class MyWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri uri)
            {
                WebRequest w = base.GetWebRequest(uri);
                w.Timeout = 500;
                return w;
            }
        }

        public VideoFeed()
        {
            InitializeComponent();
            thread = new Thread(new ThreadStart(runVideo));
        }

        public bool Rotated
        {
            get;
            set;
        }

        private Thread thread;
        public void Start(String host, int port)
        {
            cameraBaseAddress = String.Format("http://{0}:{1}", host, port);
            feedAddress = cameraBaseAddress + "/capture";
            resolutionUpgradeAddress = cameraBaseAddress + "/control?var=framesize&val=8";

            running = true;
            thread.Start();
        }

        public void Stop()
        {
            running = false;
            thread.Abort();
        }

        private bool running = false;
        private void runVideo()
        {
            MyWebClient client = new MyWebClient();

            while (running)
            {
                try
                {
                    client.DownloadString(resolutionUpgradeAddress);
                    break;
                }
                catch (Exception) { }
            }

            while (running)
            {
                try
                {
                    byte[] data = client.DownloadData(feedAddress);
                    Image img = Bitmap.FromStream(new MemoryStream(data));
                    if (Rotated)
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    Invoke((MethodInvoker)delegate
                    {
                        pictureBox.Image = img;
                    });
                }
                catch (Exception) { }
                Thread.Sleep(30);
            }
        }
    }
}
