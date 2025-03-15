﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Game.Map
{
    public struct Coordinate
    {
        public int X { get; }
        public int Y { get; }

        public Coordinate(int y, int x)
        {
            Y = y;
            X = x;
        }
    }
}
