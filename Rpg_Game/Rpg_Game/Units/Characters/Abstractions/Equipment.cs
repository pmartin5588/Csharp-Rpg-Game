using Rpg_Game.Units.Characters.Abstractions.Slot;

namespace Rpg_Game.Units.Characters.Abstractions;

public class Equipment
{
    public WeaponSlot WeaponSlot { get; }
    public ChestSlot ChestSlot { get; }
    public LegSlot LegSlot { get; }

    public Equipment()
    {
        WeaponSlot = new WeaponSlot();
        ChestSlot = new ChestSlot();
        LegSlot = new LegSlot();
    }
}