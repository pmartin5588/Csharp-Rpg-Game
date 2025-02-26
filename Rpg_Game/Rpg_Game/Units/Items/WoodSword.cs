using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Items.Abstractions.Item;
using Rpg_Game.Units.Items.Abstractions.Item.Weapon;

namespace Rpg_Game.Units.Items;

public class WoodSword : Sword
{
    public WoodSword() : base("WoodSword", 100, new Attributes(2, 0,0, 0))
    {
        
    }
}