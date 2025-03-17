using Rpg_Game.Game.Map;
using Rpg_Game.Game.Map.Tiles;
using Rpg_Game.Units.Characters.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Game.Game.Battle;
using Rpg_Game.Units.Characters.Enemy;
using Rpg_Game.Units.Characters.Hero;

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
            if(Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].IsBlocked == false &&
               Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].Character is not Enemy)
            {
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
                Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].Character = Character;
                Character.Coordinate = Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].Coordinate;
            }
            else if (Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].IsBlocked == false &&
                     Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].Character is Enemy)
            {
                var battleRunner = new BattleRunner((Hero)Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character, (Enemy)Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].Character);
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
                Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].Character = Character;
                Character.Coordinate = Map.Layout[Character.Coordinate.Y - 1, Character.Coordinate.X].Coordinate;
                battleRunner.RunBattle();
            }
        }
        public void RightStep() 
        {
            if(Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].IsBlocked == false &&
               Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].Character is not Enemy)
            {
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].Character = Character;
                Character.Coordinate = Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].Coordinate;
            }
            else if (Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].IsBlocked == false &&
                     Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].Character is Enemy)
            {
                var battleRunner =
                    new BattleRunner((Hero)Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character,
                        (Enemy)Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].Character);
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].Character = Character;
                Character.Coordinate = Map.Layout[Character.Coordinate.Y, Character.Coordinate.X + 1].Coordinate;
                battleRunner.RunBattle();
            }
        }
        public void DownStep() 
        {
            if(Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].IsBlocked == false &&
               Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].Character is not Enemy)
            {
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
                Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].Character = Character;
                Character.Coordinate = Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].Coordinate;
            }
            else if (Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].IsBlocked == false &&
                     Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].Character is Enemy)
            {
                var battleRunner =
                    new BattleRunner((Hero)Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character,
                        (Enemy)Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].Character);
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
                Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].Character = Character;
                Character.Coordinate = Map.Layout[Character.Coordinate.Y + 1, Character.Coordinate.X].Coordinate;
                battleRunner.RunBattle();
            }
        }
        public void LeftStep() 
        {
            if(Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].IsBlocked == false &&
               Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].Character is not Enemy)
            {
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].Character = Character;
                Character.Coordinate = Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].Coordinate;
            }
            else if (Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].IsBlocked == false &&
                     Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].Character is Enemy)
            {
                var battleRunner =
                    new BattleRunner((Hero)Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character,
                        (Enemy)Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].Character);
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X].Character = null;
                Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].Character = Character;
                Character.Coordinate = Map.Layout[Character.Coordinate.Y, Character.Coordinate.X - 1].Coordinate;
                battleRunner.RunBattle();
            }
        }
    }
}
