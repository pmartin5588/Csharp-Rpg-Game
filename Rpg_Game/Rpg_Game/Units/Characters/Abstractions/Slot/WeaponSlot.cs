using Rpg_Game.Units.Items.Abstractions.Enums;

namespace Rpg_Game.Units.Characters.Abstractions.Slot;

public class WeaponSlot : Slot
{
    public WeaponSlot()
    {
        RestrictedItemType = ItemType.Weapon;
    }
}