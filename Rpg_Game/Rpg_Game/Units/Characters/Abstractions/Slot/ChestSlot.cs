using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Characters.Abstractions.Slot;

public class ChestSlot : Slot
{
    public void Equip(Chest chest)
    {
        base.Equip(chest);
    }
}