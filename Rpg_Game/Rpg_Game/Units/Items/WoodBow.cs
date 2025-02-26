using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Items.Abstractions.Item.Weapon;

namespace Rpg_Game.Units.Items;

public class WoodBow : Bow
{
    public WoodBow() : base("Wood Bow", 100, new Attributes(0, 10, 0, 0))
    {
        
    }
}