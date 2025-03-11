using Rpg_Game.Game.Map.Tiles;
using Rpg_Game.Game.Map.Tiles.Abstraction;
using Rpg_Game.Units.Characters.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rpg_Game.Game.Map
{
    public class Map
    {
        public Tile[,] Layout => new Tile[,] // Getter
        {
            { W, W, W, W, W, W, W, W, W },
            { W, O, O, O, O, O, O, O, W },
            { W, O, O, O, O, O, O, O, W },
            { W, O, O, O, O, O, O, O, W },
            { W, O, O, O, O, O, O, O, W },
            { W, O, O, O, O, O, O, O, W },
            { W, O, O, O, O, O, O, O, W },
            { W, O, O, O, O, O, O, O, W },
            { W, O, O, O, O, O, O, O, W },
            { W, O, O, O, O, O, O, O, W },
            { W, O, O, O, O, W, W, O, W },
            { W, O, O, O, O, W, O, O, W },
            { W, O, O, O, O, W, O, O, W },
            { W, W, W, W, W, W, W, W, W },
        };

        private static Wall W => new();
        private static Ground O => new();


        public Map(Character character)
        {
            for (var i = 0; i < Layout.GetLength(1); i++) 
            {
                for(var j = 0; j < Layout.GetLength(0); j++) 
                {
                    Layout[i, j].Coordinate = new Coordinate(i,j);
                }
            }

            character.Coordinate = new Coordinate(1,1);     
            this.Layout[1,1].Character = character;
        }
    }
}
