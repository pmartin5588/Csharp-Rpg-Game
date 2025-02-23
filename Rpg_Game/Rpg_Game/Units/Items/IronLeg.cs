using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Items.Abstractions.Enums;
using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Items;

public class IronLeg : Item
{
    public IronLeg() : base("Iron Leg", 150, ItemType.Leg, new Attributes(1,1,0))
    {
        
    }
}