using Rpg_Game.Units.Items.Abstractions.Enums;
using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Characters.Abstractions.Slot;

public abstract class Slot
{
    public Item Item { get; private set; }
    protected ItemType RestrictedItemType { get; set; }

    public void Equip(Item item)
    {
        if (item.ItemType == RestrictedItemType)
        {
            Item = item;
        }
        else
        {
            throw new Exception("Unsupported item type");
        }
    }
}