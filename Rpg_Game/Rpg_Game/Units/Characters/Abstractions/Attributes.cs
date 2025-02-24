namespace Rpg_Game.Units.Characters.Abstractions;

public class Attributes
{
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
    
    public int Defense { get; set; }

    public Attributes(int strength, int agility, int intelligence, int defense)
    {
        Strength = strength;
        Agility = agility;
        Intelligence = intelligence;
        Defense = defense;
    }
}