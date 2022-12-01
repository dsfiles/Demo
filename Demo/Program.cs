public class Program
{
    static void Main(string[] args)
    {
        // car1 does not have any information.
        var car1 = new Vehicle();
        var car2 = new Vehicle("1FM0122021", "Ford", "Mercury", 0);
        car2.Drive(100);
        Console.Write("Car #1: ");
        car1.Display();
        Console.Write("Car #2: ");
        car2.Display();
        car2.Drive(90);
        Console.Write("After driving car #2 90 miles\nCar #2: ");
        car2.Display();
    }
}