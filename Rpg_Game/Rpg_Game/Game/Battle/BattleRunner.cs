using Rpg_Game.Units.Characters.Enemy;
using Rpg_Game.Units.Characters.Hero;

namespace Rpg_Game.Game.Battle;

public class BattleRunner
{
    private Hero Hero { get; }
    private Enemy Enemy { get; }

    public BattleRunner(Hero hero, Enemy enemy)
    {
        Hero = hero;
        Enemy = enemy;
    }

    public void RunBattle()
    {
        Console.WriteLine("BATTLE BEGINS");
        Thread.Sleep(2000);
        Console.Clear();

        while (Hero.Health > 0 && Enemy.Health > 0) 
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

            Hero.BattleActions.Attack(Enemy);
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
            Thread.Sleep(5000);
            Console.Clear();

        }
    }

}