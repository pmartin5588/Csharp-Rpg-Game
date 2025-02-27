using Rpg_Game.Units.Characters.Abstractions.Enums;
using Rpg_Game.Units.Skills;
using static System.Net.Mime.MediaTypeNames;

namespace Rpg_Game.Units.Characters.Abstractions;

public abstract class Character
{
    public string Name { get; }
    public Race Race { get; }
    public int Health { get; private set; }
    public int Mana { get; private set; }
    public Attributes Attributes { get;  }
    public Equipment Equipment { get; }
    
    public BattleActions BattleActions { get; }

    protected Character(string name, Race race)
    {
        Name = name;
        Race = race;
        Health = Race == Race.Human ? 100 : 130;
        Mana = Race == Race.Human ? 60 : 30;
        Equipment = new Equipment();
        BattleActions = new BattleActions(this);
        Attributes = Race == Race.Human 
            ? new Attributes(5, 7, 3, 3) 
            : new Attributes(8, 3, 1, 5);
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