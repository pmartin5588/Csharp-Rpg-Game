using Rpg_Game.Units.Characters.Hero;
using System.Security.Cryptography;
using Rpg_Game.Game.Map;

namespace Rpg_Game.Game;

public class GameRunner
{
    public Hero Hero { get; }
    public Rpg_Game.Game.Map.Map Map { get; }
    public bool IsExiting { get; private set; } = false;
    public string _playerName { get; private set; }
    InterfaceWithUser _interfaceWithUser = new InterfaceWithUser();

    public GameRunner(Hero hero, Rpg_Game.Game.Map.Map map)
    {
        Hero = hero;
        Map = map;
    }


    public void StartMenu()
    {
        _interfaceWithUser.PrintStartMenu();
        var selectedMenuPoint = _interfaceWithUser.SelectStartOption();
        switch (selectedMenuPoint)
        {
            case 1:
                StartGame();
                break;
            case 2:
                IsExiting = true;
                break;
        }
        Console.Clear();
    }
    
    private void StartGame()
    {
        _playerName = _interfaceWithUser.CharacterCreation();
        Hero.SetName(_playerName);
        RunOpenWorld();
    }

    public void RunOpenWorld()
    {
        while (true)
        {
            Map.PrintMap();

            ConsoleKeyInfo consoleKey = Console.ReadKey();
            switch (consoleKey.Key)
            {
                case ConsoleKey.RightArrow:
                    Hero.MovementActions.RightStep();
                    break;
                case ConsoleKey.UpArrow:
                    Hero.MovementActions.UpStep();
                    break;
                case ConsoleKey.DownArrow:
                    Hero.MovementActions.DownStep();
                    break;
                case ConsoleKey.LeftArrow:
                    Hero.MovementActions.LeftStep();
                    break;
                default:
                    break;
            }

        }
    }
}