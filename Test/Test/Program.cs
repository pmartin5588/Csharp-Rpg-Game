namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pigeon = new Pigeon();
            var penguin = new Penguin();

            var birdList = new List<Bird>();

            birdList.Add(pigeon);
            birdList.Add(penguin);

            var fliableList = new List<IFliable>();
            fliableList = birdList.OfType<IFliable>().ToList();

            var a = birdList.OfType<IFliable>();

            Thread.Sleep(10000);

            var b = a.ToList();


            Console.ReadLine();
        }
    }
}

public static class Bomb
{
    public static void Detonate(IFliable fliableSpecies)
    {
        try
        {
            fliableSpecies.Fly();
        }
        catch
        {
            Console.WriteLine("Explode!");
        }
    }
}

public abstract class Bird
{
    public abstract string TypeName { get; set; }
}

public interface IFliable
{
    public void Fly();
}

public class Pigeon : Bird, IFliable
{
    public void Fly()
    {
        Console.WriteLine("I can fly");
    }

    public override string TypeName { get; set; } = "Pigeon";
}

public class Penguin : Bird
{
    public override string TypeName { get; set; } = "Penguin";
}