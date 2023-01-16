#define LIVE

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace MiniCar
{
    public partial class MainForm : Form
    {
        private const string host = "192.168.4.1";
        private const int portStream = 80;
        private const int portControl = 23;
        private int color = 0;

        private readonly Comm comm;
        private GlobalKeyboardHook hook = new GlobalKeyboardHook();

        public MainForm()
        {
            InitializeComponent();

            trackBarSpeed.Minimum = Command.PARAM_MIN;
            trackBarSpeed.Maximum = Command.PARAM_MAX;
            trackBarSpeed.Value = trackBarSpeed.Maximum / 2;

            comm = new Comm(this);
            comm.Received += new Comm.ReceivedDelegate(comm_Received);
            comm.Rotated += new Comm.RotatedDelegate(comm_Rotated);

            hook.KeyboardPressed += new EventHandler<GlobalKeyboardHookEventArgs>(hook_KeyboardPressed);
        }

        public void comm_Rotated()
        {
            videoFeed.Rotated = true;
            miniMap.IsCallidus = true;
        }

        private void hook_KeyboardPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            Command command;

            switch (e.KeyboardState)
            {
                case GlobalKeyboardHook.KeyboardState.KeyUp:
#if !LIVE
                    BackColor = Color.Green;
#endif
                    command = new Command(CommandType.Stop);
#if LIVE
                    comm.Send(command);
#endif
                    miniMap.HandleCommand(command);
                    break;

                case GlobalKeyboardHook.KeyboardState.KeyDown:
#if !LIVE
                    BackColor = Color.Red;
#endif
                    int code = e.KeyboardData.VirtualCode;

                    if (code == (int)VirtualKeys.W)
                        command = new Command(CommandType.Forward, trackBarSpeed.Value);
                    else if (code == (int)VirtualKeys.S)
                        command = new Command(CommandType.Backward, trackBarSpeed.Value);
                    else if (code == (int)VirtualKeys.A)
                        command = new Command(CommandType.Left, trackBarSpeed.Value);
                    else if (code == (int)VirtualKeys.D)
                        command = new Command(CommandType.Right, trackBarSpeed.Value);
                    else if (code == (int)VirtualKeys.X)
                        command = new Command(CommandType.Stop, 1);
                    else if (code == (int)VirtualKeys.P)
                        command = new Command(CommandType.Play, 16);
                    else if (code == (int)VirtualKeys.I)
                        command = new Command(CommandType.Play, 2);
                    else if (code == (int)VirtualKeys.O)
                        command = new Command(CommandType.Volume, 0);
                    else if (code == (int)VirtualKeys.K)
                        command = new Command(CommandType.Volume, 5);
                    else if (code == (int)VirtualKeys.L)
                        command = new Command(CommandType.Volume, 20);
                    else if (code == (int)VirtualKeys.N)
                    {
                        colorTimer.Stop();
                        return;
                    }
                    else if (code == (int)VirtualKeys.M)
                    {
                        colorTimer.Start();
                        return;
                    }
                    else
                        return;

#if LIVE
                    comm.Send(command);
#endif
                    miniMap.HandleCommand(command);
                    break;

                default:
                    return;
            }

            e.Handled = true;
        }

        private void comm_Received(Response response)
        {
            miniMap.HandleResponse(response);
 	        panelSensorLeft.BackColor = response.LineSensorLeft ? Color.LightGreen : Color.Red;
            panelSensorMiddle.BackColor = response.LineSensorMiddle ? Color.LightGreen : Color.Red;
            panelSensorRight.BackColor = response.LineSensorRight ? Color.LightGreen : Color.Red;
            labelDistance.Text = String.Format("{0}{1} cm", response.DistanceCentimeters + 1 > Response.DISTANCE_MAX ? ">" : "", response.DistanceCentimeters);
            labelWarning.Visible = response.DistanceCentimeters <= 12;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
#if LIVE
            comm.Start(host, portControl);
            videoFeed.Start(host, portStream);
            colorTimer.Start();
#endif
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
#if LIVE
            videoFeed.Stop();
            comm.Stop();
#endif
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            comm.Send(new Command(CommandType.Light, color));
            color++;
            color &= 15;
        }
    }
}
