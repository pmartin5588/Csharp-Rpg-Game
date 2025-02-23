using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Items.Abstractions.Enums;
using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Items;

public class IronCuirass : Item
{
    public IronCuirass() : base("Iron Cuirass", 150, ItemType.Chest, new Attributes(1,1,0))
    {
        
    }
}