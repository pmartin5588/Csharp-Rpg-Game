using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Items.Abstractions.Enums;

namespace Rpg_Game.Units.Items.Abstractions.Item;

public abstract class Item
{
    public string Name { get;  }
    public Attributes Attributes { get; }
    public int Price { get; }
    public ItemType ItemType { get; }

    public Item(string name, int price, ItemType itemType, Attributes attributes)
    {
        Name = name;
        Price = price;
        ItemType = itemType;
        Attributes = attributes;
    }
}