using Rpg_Game.Units.Characters.Abstractions;


namespace Rpg_Game.Units.Items.Abstractions.Item;

public class Chest : Item
{
    public Chest(string name, int price, Attributes attributes) : base(name, price, attributes)
    {
    }
}