using Rpg_Game.Game;
using Rpg_Game.Game.Battle;
using Rpg_Game.Game.Map;
using Rpg_Game.Units.Characters;
using Rpg_Game.Units.Characters.Abstractions.Enums;
using Rpg_Game.Units.Characters.Enemy;
using Rpg_Game.Units.Characters.Hero;
using Rpg_Game.Units.Items;
using Rpg_Game.Units.Skills;

namespace Rpg_Game;

class Program
{
    static void Main(string[] args)
    {
        Map map = new Map();
        var player = new Hero(Race.Human, map);
        GameRunner gameRunner = new GameRunner(player, map);
        gameRunner.StartMenu();
 
        var woodSword = new WoodSword();
        var woodBow = new WoodBow();
        var ironCuirass = new IronCuirass();
        var ironLeg = new IronLeg();
        var magicStick = new MagicStick();
        var enemy = new Enemy("Orc", Race.Orc, map);
        player.Equipment.ChestSlot.Equip(ironCuirass);
        player.Equipment.WeaponSlot.Equip(magicStick);

        map.printMap();

        var battleRunner = new BattleRunner(player, enemy);
        battleRunner.RunBattle();

    }
}