using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Characters.Enemy;
using Rpg_Game.Units.Characters.Hero;
using Rpg_Game.Units.Skills;

namespace Rpg_Game.Game.Battle;

public class BattleRunner
{
    private Hero Hero { get; }
    private Enemy Enemy { get; }
    
    private BattleActions BattleActions { get; }

    public BattleRunner(Hero hero, Enemy enemy)
    {
        Hero = hero;
        Enemy = enemy;
    }

    public void RunBattle()
    {
        var battleFlag = 1;
        
        Console.WriteLine("BATTLE BEGINS");
        Thread.Sleep(2000);
        Console.Clear();

        while (battleFlag > 0) 
        {
            Console.WriteLine("");
            Console.WriteLine($"[{Hero.Name} HP: {Hero.Health}]");
            Console.WriteLine($"[{Hero.Name} MANA: {Hero.Mana}]");
            Console.WriteLine("");
            Console.WriteLine($"[{Enemy.Name} HP: {Enemy.Health}]");
            Console.WriteLine($"[{Enemy.Name} MANA: {Enemy.Mana}]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"{Hero.Name} turn:".ToUpper());
            Console.WriteLine("");

            ChooseBattleAction(Hero);
            battleFlag = CheckHealth();
            if (battleFlag == 0)
            {
                break;
            }
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"[{Hero.Name} HP: {Hero.Health}]");
            Console.WriteLine($"[{Hero.Name} MANA: {Hero.Mana}]");
            Console.WriteLine("");
            Console.WriteLine($"[{Enemy.Name} HP: {Enemy.Health}]");
            Console.WriteLine($"[{Enemy.Name} MANA: {Enemy.Mana}]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"{Enemy.Name} turn:".ToUpper());
            Console.WriteLine("");

            Enemy.Script.RandomActOnHero(Hero);
            battleFlag = CheckHealth();
            if (battleFlag == 0)
            {
                break;
            }
            Thread.Sleep(5000);
            Console.Clear();
        }
    }

    public void ChooseBattleAction(Character character)
    {
        int ChosenAction;
        Console.WriteLine("Choose an action:\r\n");
        for (var i = 0; i < (character.BattleActions.ListOfBattleActions).Count; i++)
        {
            Console.WriteLine($"{i + 1}. {character.BattleActions.ListOfBattleActions[i]}");
        }

        while (true)
        {
            var result = int.TryParse(Console.ReadLine(), out ChosenAction);
            if (result == true && ChosenAction > 0 && ChosenAction <= character.BattleActions.ListOfBattleActions.Count)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }

        switch (ChosenAction)
        {
            case 1:
                Hero.BattleActions.Attack(Enemy);
                break;
            case 2:
                Hero.BattleActions.Defense(Hero);
                break;
            case 3:
                Hero.BattleActions.Magics[0].Cast(Enemy);
                break;
            case 4:
                Hero.BattleActions.Magics[1].Cast(Enemy);
                break;
            default:
                break;
        }
    }

    public int CheckHealth()
    {
        if (Hero.Health <= 0)
        {
            Console.Clear();
            Console.WriteLine("You died.");
            Thread.Sleep(5000);
            return 0;
        }
        else if (Enemy.Health <= 0)
        {
            Console.Clear();
            Console.WriteLine("You won.");
            Thread.Sleep(5000);
            return 0;
        }
        return 1;
    }

}