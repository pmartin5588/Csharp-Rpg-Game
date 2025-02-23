using Rpg_Game.Units.Items.Abstractions.Enums;

namespace Rpg_Game.Units.Characters.Abstractions.Slot;

public class ChestSlot : Slot
{
    public ChestSlot()
    {
        RestrictedItemType = ItemType.Chest;
    }
}