using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniCar
{
    public enum CommandType
    {
        Stop,       // 0: 000
        Forward,    // 1: 001
        Backward,   // 2: 010
        Left,       // 3: 011
        Right,       // 4: 100
        Play,
        Volume,
        Light
    }
}
