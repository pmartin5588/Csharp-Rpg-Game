using Rpg_Game.Units.Characters;
using Rpg_Game.Units.Characters.Abstractions.Enums;
using Rpg_Game.Units.Items;

namespace Rpg_Game;

class Program
{
    static void Main(string[] args)
    {
        var woodSword = new WoodSword();
        var ironCuirass = new IronCuirass();
        var ironLeg = new IronLeg();
        var player = new Hero("Martin", Race.Human);
        var enemy = new Enemy("Orc", Race.Orc);
        
        player.Equipment.ChestSlot.Equip(ironCuirass);
    }
}