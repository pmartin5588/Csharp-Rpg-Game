using Rpg_Game.Units.Characters.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Game.Map.Tiles.Abstraction
{
    public abstract class Tile
    {
        public Character Character { get; set; }
        public Coordinate Coordinate { get; set; }

        public abstract bool IsBlocked { get; }
    }
}
