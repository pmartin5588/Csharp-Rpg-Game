using Rpg_Game.Game.Map.Tiles.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Game.Map.Tiles
{
    public class Ground : Tile
    {
        public override bool IsBlocked => false;
    }
}
