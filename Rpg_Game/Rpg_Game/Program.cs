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

        GameRunner gameRunner = new GameRunner();
        gameRunner.StartMenu();
        
        var woodSword = new WoodSword();
        var woodBow = new WoodBow();
        var ironCuirass = new IronCuirass();
        var ironLeg = new IronLeg();
        var magicStick = new MagicStick();
        var player = new Hero(gameRunner._playerName, Race.Human);
        var enemy = new Enemy("Orc", Race.Orc);
        
        
        player.Equipment.ChestSlot.Equip(ironCuirass);
        player.Equipment.WeaponSlot.Equip(magicStick);

        var battleRunner = new BattleRunner(player, enemy);
        battleRunner.RunBattle();

    }
}