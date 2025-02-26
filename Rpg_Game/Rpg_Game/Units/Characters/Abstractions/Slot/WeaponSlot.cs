using Rpg_Game.Units.Items.Abstractions.Item;
using Rpg_Game.Units.Items.Abstractions.Item.Weapon;

namespace Rpg_Game.Units.Characters.Abstractions.Slot;

public class WeaponSlot : Slot
{
    public void Equip(Weapon weapon)
    {
        base.Equip(weapon);
    }
}