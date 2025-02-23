namespace Rpg_Game;

public class Attributes
{
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }

    public Attributes(int strength, int agility, int intelligence)
    {
        Strength = strength;
        Agility = agility;
        Intelligence = intelligence;
    }
}