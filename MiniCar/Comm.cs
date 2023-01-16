using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace MiniCar
{
    public class Comm
    {
        private readonly TcpClient client;
        private readonly Form parent;
        private NetworkStream stream = null;
        private readonly Thread thread;
        private bool running = false;
        private bool lastFlag = false;

        public delegate void ReceivedDelegate(Response response);
        public event ReceivedDelegate Received;

        public delegate void RotatedDelegate();
        public event RotatedDelegate Rotated;

        public Comm(Form parent)
        {
            client = new TcpClient();
            this.parent = parent;
            thread = new Thread(new ThreadStart(Receive));
        }

        public void Start(String host, int port)
        {
            running = false;
            while (stream != null)
                Thread.Sleep(100);

            running = true;
            client.Connect(host, port);
            stream = client.GetStream();
            stream.ReadTimeout = 500;
            stream.WriteTimeout = 500;

            thread.Start();
        }

        public void Stop()
        {
            running = false;
        }

        private void Receive()
        {
            while (running)
            {
                try
                {
                    int packet = stream.ReadByte();

                    bool triggered = lastFlag && packet == 0;
                    lastFlag = packet == 0xff;
                    if (triggered)
                    {
                        OnRotated();
                        return;
                    }

                    OnReceived(new Response(packet));
                }
                catch (Exception) { }
            }

            stream.Close();
            client.Close();
            stream = null;
        }

        public void Send(Command command)
        {
            try
            {
                stream.WriteByte((byte)command.Packet);
            }
            catch (Exception) { }
        }

        private void OnReceived(Response response)
        {
            if (Received == null)
                return;

            parent.Invoke((MethodInvoker)delegate
            {
                Received(response);
            });
        }

        private void OnRotated()
        {
            if (Rotated == null)
                return;

            parent.Invoke((MethodInvoker)delegate
            {
                Rotated();
            });
        }
    }
}
