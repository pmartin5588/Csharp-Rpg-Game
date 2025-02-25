using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Items.Abstractions.Enums;
using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Items;

public class WoodSword : Item
{
    public WoodSword() : base("WoodSword", 100, ItemType.Weapon, new Attributes(2, 0,0, 0))
    {
        
    }
}