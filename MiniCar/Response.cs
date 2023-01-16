using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniCar
{
    public class Response
    {
        public const int DISTANCE_MAX = 100;

        private readonly int distanceCentimeters;
        private readonly bool lineSensorLeft;
        private readonly bool lineSensorMiddle;
        private readonly bool lineSensorRight;

        public Response(int packet)
        {
            // Format LSB -> MSB:
            // 101 -> 1*4 + 0*2 + 1*1 = 5

            // 0:    LineSensorLeft:    1 bit
            // 1:    LineSensorMiddle:  1 bit
            // 2:    LineSensorRight:   1 bit
            // 3..7: Distance:          5 bit

            // Packet:
            // 10101011
            //       /|\
            // Maskieren:
            //   10101011
            // & 00000001
            // = 00000001
            // = 1 > 0 = true
            // = 0 > 0 = false
            lineSensorLeft = (packet & 1 /* 001 */) > 0;

            // 10101011
            //      /|\
            // Maskieren:
            //   10101011
            // & 00000010
            // = 00000010
            // = 10 > 0 = true
            // = 00 > 0 = false
            lineSensorMiddle = (packet & 2 /* 010 */) > 0;

            // 10101011
            //     /|\
            // Maskieren:
            //   10101011
            // & 00000100
            // = 00000000
            // = 100 > 0 = true
            // = 000 > 0 = false
            lineSensorRight = (packet & 4 /* 100 */) > 0;

            // 10101011
            //      xxx
            // 10101011 >> 3
            // 00010101

            // 1m ^= 31 (11111 = 5 Bits)
            // 1m / 31 = 100cm / 31 = 3.23 cm / 1
            distanceCentimeters = (packet >> 3) * 100 / 31;
        }

        public bool LineSensorLeft
        {
            get
            {
                return lineSensorLeft;
            }
        }

        public bool LineSensorMiddle
        {
            get
            {
                return lineSensorMiddle;
            }
        }

        public bool LineSensorRight
        {
            get
            {
                return lineSensorRight;
            }
        }

        public int DistanceCentimeters
        {
            get
            {
                return distanceCentimeters;
            }
        }
    }
}
