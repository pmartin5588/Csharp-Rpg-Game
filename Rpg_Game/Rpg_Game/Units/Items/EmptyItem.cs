using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Items.Abstractions.Enums;
using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Items;

public class EmptyItem : Item
{
    public EmptyItem() : base("Empty", 0, ItemType.Empty, new Attributes(0,0,0, 0), WeaponType.Empty)
    {
        
    }
}