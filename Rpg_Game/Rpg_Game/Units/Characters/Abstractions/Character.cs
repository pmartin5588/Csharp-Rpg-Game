using Rpg_Game.Game.Map;
using Rpg_Game.Units.Characters.Abstractions.Enums;
using Rpg_Game.Units.Skills;
using static System.Net.Mime.MediaTypeNames;

namespace Rpg_Game.Units.Characters.Abstractions;

public abstract class Character
{
    public string Name { get; private set; }
    public Race Race { get; }
    public int Health { get; private set; }
    public int Mana { get; private set; }
    public Attributes Attributes { get;  }
    public Equipment Equipment { get; }
    
    public BattleActions BattleActions { get; }
    public MovementActions MovementActions { get; }

    public Coordinate Coordinate { get; set; }

    protected Character(string name, Race race, Map map)
    {
        Name = name;
        Race = race;
        Health = Race == Race.Human ? 100 : 130;
        Mana = Race == Race.Human ? 60 : 30;
        Equipment = new Equipment();
        BattleActions = new BattleActions(this);
        MovementActions = new MovementActions(map, this);
        Attributes = Race == Race.Human 
            ? new Attributes(10, 6, 6, 7) 
            : new Attributes(14, 4, 3, 5);
    }

    protected Character(Race race, Map map)
    {
        Race = race;
        Health = Race == Race.Human ? 100 : 130;
        Mana = Race == Race.Human ? 60 : 30;
        Equipment = new Equipment();
        BattleActions = new BattleActions(this);
        MovementActions = new MovementActions(map, this);
        Attributes = Race == Race.Human
            ? new Attributes(10, 6, 6, 7)
            : new Attributes(14, 4, 3, 5);
    }


    public void SetName(string name)
    {
        Name = name;
    }

    public void TakeDamage(int damage)
    {
        Health = Health - damage;
        Console.WriteLine($"{this.Name} suffered {damage} damage.\r\n");
    }

    public void TakeMana(int mana)
    {
        Mana -= mana;
    }
}