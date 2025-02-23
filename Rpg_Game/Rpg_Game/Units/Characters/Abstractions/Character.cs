namespace Rpg_Game;

public abstract class Character
{
    public int Health { get; private set; }
    public int Mana { get; private set; }
    public string Name { get; }
    public Race Race { get; }
    
    public Attributes Attributes { get;  }
    public Equipment Equipment { get; }

    public Character(string name, Race race, int health, int mana)
    {
        Name = name;
        Race = race;
        Health = health;
        Mana = mana;
        Equipment = new Equipment();

        if (race == Race.Human)
        {
            Attributes = new Attributes(5,7,3);
        }
        else
        {
            Attributes = new Attributes(8, 3, 1);
        }
        
    }
}