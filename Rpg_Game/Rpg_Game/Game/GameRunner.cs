namespace Rpg_Game.Game;

public class GameRunner
{
    public bool IsExiting { get; private set; } = false;
    public string _playerName { get; private set; }
    InterfaceWithUser _interfaceWithUser = new InterfaceWithUser();
    
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
    }
    
    private void StartGame()
    {
        Console.WriteLine("Create a new character!");
        Console.Write("Name: ");
        _playerName = _interfaceWithUser.SelectCharacterName();
    }
}