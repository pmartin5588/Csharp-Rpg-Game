using Rpg_Game.Units.Items;
using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Characters.Abstractions.Slot;

public abstract class Slot
{
    public Item Item { get; private set; }
    
    protected void Equip(Item item)
    {
        Item = item;
    }
}