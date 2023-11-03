using OopAccessLevels.Library;

namespace OopAccessLevels.App
{
    public class SuvCar : Car
    {
        void SuvPrintManufacturer()
        {
            // Car private field not accessible in child class 
            // from another project
            // Console.WriteLine(manufacturer);

            // Car protected field accesssible in child class
            // from another project
            Console.WriteLine(model);
        }
    }
}
