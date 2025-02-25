using Rpg_Game.Units.Items;
using Rpg_Game.Units.Items.Abstractions.Enums;
using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Characters.Abstractions.Slot;

public abstract class Slot
{
    public Item Item { get; private set; } = new EmptyItem();
    protected ItemType RestrictedItemType { get; set; }
    
    protected void Equip(Item item)
    {
        if (item.ItemType == RestrictedItemType && item.ItemType != ItemType.Weapon)
        {
            Item = item;
        }
        else if (item.ItemType == ItemType.Weapon && item.WeaponType != WeaponType.Empty)
        {
            Item = item;
        }
        else
        {
            throw new Exception("Unsupported item type");
        }
    }
}