using Rpg_Game.Units.Characters.Abstractions;

namespace Rpg_Game.Units.Items.Abstractions.Item;

public abstract class Item
{
    public string Name { get; }
    public Attributes Attributes { get; }
    public int Price { get; }

    public Item(string name, int price, Attributes attributes)
    {
        Name = name;
        Price = price;
        Attributes = attributes;
    }
}