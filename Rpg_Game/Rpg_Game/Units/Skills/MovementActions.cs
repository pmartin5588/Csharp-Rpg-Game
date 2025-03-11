using Rpg_Game.Game.Map;
using Rpg_Game.Units.Characters.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Units.Skills
{
    public class MovementActions
    {
        private Map Map { get; }
        private Character Character { get; }

        public MovementActions(Map map)
        {
            Map = map;
        }

        public void UpStep()
        {
            Map.Layout[Character.Coordinate.X, Character.Coordinate.Y].Character = null;
            Map.Layout[Character.Coordinate.X, Character.Coordinate.Y - 1].Character = Character;
            Character.Coordinate = Map.Layout[Character.Coordinate.X, Character.Coordinate.Y - 1].Coordinate;
        }
        public void RightStep() 
        {

        }
        public void DownStep() { }
        public void LeftStep() { }


    }
}
