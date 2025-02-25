using Rpg_Game.Units.Items.Abstractions.Enums;
using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Characters.Abstractions.Slot;

public class ChestSlot : Slot
{
    public ChestSlot()
    {
        RestrictedItemType = ItemType.Chest;
    }

    public void Equip(Chest item2)
    {
        base.Equip(item2);
    }
}