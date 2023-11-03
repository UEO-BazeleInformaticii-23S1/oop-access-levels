using OopAccessLevels.Library;

namespace OopAccessLevels.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.manufacturer);
        }
    }
}