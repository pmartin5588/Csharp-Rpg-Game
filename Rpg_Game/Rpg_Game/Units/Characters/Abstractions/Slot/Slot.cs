namespace Rpg_Game;

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