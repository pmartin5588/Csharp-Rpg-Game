using Rpg_Game.Game.Map;
using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Characters.Abstractions.Enums;

namespace Rpg_Game.Units.Characters.Enemy;

public class Enemy : Character
{
    public Script Script { get; }

    public Enemy(string name, Race race, Map map) : base(name, race, map)
    {
        Script = new Script(this);
        map.PlaceEnemyOnMap(this);
    }
}