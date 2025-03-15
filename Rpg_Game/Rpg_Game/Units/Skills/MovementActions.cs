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

        public MovementActions(Map map, Character character)
        {
            Map = map;
            Character = character;
        }

        public void UpStep()
        {
            Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
            Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].Character = Character;
            Character.Coordinate = Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].Coordinate;
        }
        public void RightStep() 
        {
            Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
            Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].Character = Character;
            Character.Coordinate = Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].Coordinate;
        }
        public void DownStep() 
        {
            Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
            Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].Character = Character;
            Character.Coordinate = Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].Coordinate;
        }
        public void LeftStep() 
        {
            Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
            Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].Character = Character;
            Character.Coordinate = Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].Coordinate;
        }


    }
}
