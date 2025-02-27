namespace Rpg_Game.Game;

public class InterfaceWithUser
{
    public void PrintStartMenu()
    {
        Console.WriteLine("Welcome to the Game!");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Start Game");
        Console.WriteLine("2. Exit Game");
    }

    public int SelectStartOption()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out var result) && result > 0 && result < 3)
            {
                return result;
            }
            Console.WriteLine("Invalid input. Try again.");
        }
    }

    public string CharacterCreation()
    {
        Console.WriteLine("Create a new character!");
        while (true)
        {
            Console.Write("Name: ");
            var input = Console.ReadLine();
            Console.WriteLine("");
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input! Try again!");
            }
            else
            {
                return input;
            }
        }
    }
}