using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Items.Abstractions.Item;

namespace Rpg_Game.Units.Items;

public class IronCuirass : Chest
{
    public IronCuirass() : base("Iron Cuirass", 150, new Attributes(0,0,0,5))
    {
        
    }
}