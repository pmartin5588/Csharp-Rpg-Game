using Rpg_Game.Game.Map.Tiles;
using Rpg_Game.Game.Map.Tiles.Abstraction;
using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Characters.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Rpg_Game.Units.Characters.Enemy;

namespace Rpg_Game.Game.Map
{
    public class Map
    {
        public Tile[,] Layout { get; }
        private static Wall W => new Wall();
        private static Ground O => new Ground();

        public Map()
        {            
            Layout = new Tile[,]
            {
                { W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, O, W },
                { W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W },
            };

            for (var y = 0; y < Layout.GetLength(0); y++)
            {
                for (var x = 0; x < Layout.GetLength(1); x++)
                {
                    Layout[y, x].Coordinate = new Coordinate(y, x);
                }
            }
        }

        public void InitPlayerOnMap(Hero hero)
        {
            hero.Coordinate = new Coordinate(1, 1);
            Layout[hero.Coordinate.Y, hero.Coordinate.X].Character = hero;
        }

        public void PlaceEnemyOnMap(Enemy enemy)
        {
            enemy.Coordinate = new Coordinate(new Random().Next(2,Layout.GetLength(0) - 1), new Random().Next(2,Layout.GetLength(1) - 1));
            Layout[enemy.Coordinate.Y, enemy.Coordinate.X].Character = enemy;
        }

        public void PrintMap()
        {
            Console.Clear();

            var xLength = Layout.GetLength(1);
            var yLength = Layout.GetLength(0);

            for(var y = 0; y < yLength; y++)
            {
                for(var x = 0;x < xLength; x++) 
                {
                    if(Layout[y,x].Character != null && Layout[y,x].Character is Hero)
                    {
                        Console.Write("@");
                    }
                    else if (Layout[y,x].Character != null && Layout[y,x].Character is Enemy)
                    {
                        Console.Write("E");
                    }
                    else if(Layout[y, x] is Wall)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
