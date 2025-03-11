using Rpg_Game.Game.Map.Tiles.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Game.Map.Tiles
{
    internal class Wall : Tile
    {
        public override bool IsBlocked => true;
    }
}
