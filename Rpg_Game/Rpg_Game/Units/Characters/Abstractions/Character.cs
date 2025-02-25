using Rpg_Game.Units.Characters.Abstractions.Enums;

namespace Rpg_Game.Units.Characters.Abstractions;

public abstract class Character
{
    public string Name { get; }
    public Race Race { get; }
    public int Health { get; private set; }
    public int Mana { get; private set; }
    public Attributes Attributes { get;  }
    public Equipment Equipment { get; }
    

    protected Character(string name, Race race)
    {
        Name = name;
        Race = race;
        Health = Race == Race.Human ? 100 : 130;
        Mana = Race == Race.Human ? 60 : 30;
        Equipment = new Equipment();

        Attributes = Race == Race.Human 
            ? new Attributes(5, 7, 3, 3) 
            : new Attributes(8, 3, 1, 5);
    }

    public void TakeDamage(int damage)
    {
        Health = Health - damage;
    }
}