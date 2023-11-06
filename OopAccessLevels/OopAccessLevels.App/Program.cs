using OopAccessLevels.Library;

namespace OopAccessLevels.App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            // Car private field not accessible in another class
            // from another project
            // Console.WriteLine(car.manufacturer);

            // Car protected field not accessible in another class
            // from another project
            // Console.WriteLine(car.model);

            // Car private-protected field not accessible in another class
            // from another project
            // Console.WriteLine(car.modelVariant);

            Console.WriteLine(car.year);
        }
    }
}