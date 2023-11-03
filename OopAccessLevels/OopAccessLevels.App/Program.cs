using OopAccessLevels.Library;

namespace OopAccessLevels.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            // Car private field not accessible in another class
            // from another project
            // Console.WriteLine(car.manufacturer);

            Console.WriteLine(car.model);
        }
    }
}