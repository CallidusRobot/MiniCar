using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniCar
{
    public class Command
    {
        public const int PARAM_MIN = 0;
        public const int PARAM_MAX = 31;

        private int packet;

        public Command(CommandType type, int param = 0) // param bei allem außer Stop die Geschwindigkeit
        {
            Type = type;
            Param = param;

            // Protocol (MSB->LSB):
            // 0..2: Type (3 Bit)
            // 3..7: Param (5 Bit)
            // 10101010
            // 00010101
            //    -----
            packet = Math.Max(Math.Min(param, PARAM_MAX), PARAM_MIN);

            //   00010101 << 3
            // = 10101000
            packet <<= 3;

            //   10101000
            // | 00000010
            // = 10101010
            //      ---
            packet |= (int) type;
        }

        public int Packet
        {
            get
            {
                return packet;
            }
        }

        public CommandType Type
        {
            get;
            private set;
        }

        public int Param
        {
            get;
            private set;
        }
    }
}
