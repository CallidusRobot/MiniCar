using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MiniCar
{
    public partial class MiniMap : UserControl
    {
        private Command lastCommand = new Command(CommandType.Stop);
        private double lastStartTime = 0d;
        private readonly Stopwatch stopwatch = new Stopwatch();
        private const double SECONDS_PER_METER_ELEGOO = 4.1d; // seconds per meter at full speed
        private const double SECONDS_PER_REVOLUTION_ELEGOO = 1.28025d; // seconds per revolution at full speed
        private const double SECONDS_PER_METER_CALLIDUS = 1.0875d; // seconds per meter at full speed
        private const double SECONDS_PER_REVOLUTION_CALLIDUS = 0.6714d; // seconds per revolution at full speed

        private double metersX = 0d;
        private double metersY = 0d;
        private double degrees = 0d;

        public bool IsCallidus
        {
            get;
            set;
        }

        public MiniMap()
        {
            InitializeComponent();
            stopwatch.Start();
            HandleCommand(lastCommand);
        }

        public void HandleCommand(Command command)
        {
            if (command.Type == CommandType.Stop && lastCommand.Type != CommandType.Stop)
            {
                double currentSeconds = stopwatch.ElapsedMilliseconds / 1000d;
                double deltaSeconds = currentSeconds - lastStartTime;

                double speed = Map(lastCommand.Param, Command.PARAM_MIN, Command.PARAM_MAX, 0d, 1d);
                double deltaDegress = 0;
                double deltaMeters = 0;

                switch (lastCommand.Type)
                {
                    case CommandType.Forward:
                        deltaMeters = deltaSeconds / (IsCallidus ? SECONDS_PER_METER_CALLIDUS : SECONDS_PER_METER_ELEGOO) * speed;
                        break;

                    case CommandType.Backward:
                        deltaMeters = -deltaSeconds / (IsCallidus ? SECONDS_PER_METER_CALLIDUS : SECONDS_PER_METER_ELEGOO) * speed;
                        break;

                    case CommandType.Left:
                        deltaDegress = deltaSeconds / (IsCallidus ? SECONDS_PER_REVOLUTION_CALLIDUS : SECONDS_PER_REVOLUTION_ELEGOO) * speed * 360d;
                        break;

                    case CommandType.Right:
                        deltaDegress = -deltaSeconds / (IsCallidus ? SECONDS_PER_REVOLUTION_CALLIDUS : SECONDS_PER_REVOLUTION_ELEGOO) * speed * 360d;
                        break;
                }

                if (deltaDegress != 0d)
                {
                    degrees += deltaDegress;
                    degrees %= 360;
                }

                if (deltaMeters != 0d)
                {
                    metersX += deltaMeters * Math.Cos(degrees / 180d * Math.PI);
                    metersY += deltaMeters * Math.Sin(degrees / 180d * Math.PI);
                }

                labelCoordinates.Text = String.Format("Distanz: {0:F3} m\nRotation: {1:F2} °\nDuration: {2:F3} s\n\n", deltaMeters, deltaDegress, deltaSeconds);
            }
            else
            {
                if (lastCommand.Type != command.Type)
                    lastStartTime = stopwatch.ElapsedMilliseconds / 1000d;

                labelCoordinates.Text = "";
            }

            labelCoordinates.Text += String.Format("X: {0:F3} m\nY: {1:F3} m\nRichtung: {2:F2} °", metersX, metersY, degrees);
            lastCommand = command;
        }

        public void HandleResponse(Response response)
        {

        }

        private double Map(double x, double in_min, double in_max, double out_min, double out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }
    }
}
