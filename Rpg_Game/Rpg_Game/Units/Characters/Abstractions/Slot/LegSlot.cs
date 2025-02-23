using Rpg_Game.Units.Items.Abstractions.Enums;

namespace Rpg_Game.Units.Characters.Abstractions.Slot;

public class LegSlot : Slot
{
    public LegSlot()
    {
        RestrictedItemType = ItemType.Leg;
    }
}