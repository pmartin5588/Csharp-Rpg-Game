using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Items.Abstractions.Item;
using Rpg_Game.Units.Items.Abstractions.Item.Weapon;

namespace Rpg_Game.Units.Items;

public class MagicStick : Staff
{
    public MagicStick() : base("Magic Stick", 150, new Attributes(0,0,9,0))
    {
        
    }
}