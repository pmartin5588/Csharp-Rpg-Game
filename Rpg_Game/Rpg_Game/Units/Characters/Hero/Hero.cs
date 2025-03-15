using Rpg_Game.Game.Map;
using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Characters.Abstractions.Enums;

namespace Rpg_Game.Units.Characters.Hero;

public class Hero : Character
{
    public Hero(string name, Race race, Map map) : base(name, race, map)
    {
        map.InitPlayerOnMap(this);
    }
}