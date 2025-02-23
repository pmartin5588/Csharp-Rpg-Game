namespace Rpg_Game;

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