using System;
namespace OopAccessLevels.Library
{
    public class CarDealer
    {
        void DealerPrintInventory()
        {
            Car car = new Car();
            // Car private field not accessible in another class
            // from within the same project
            // Console.WriteLine(car.manufacturer);

            // Car protected field not accessible in another class
            // from within the same project
            // Console.WriteLine(car.model);

            // Car private-protected field not accessible in another class
            // from within the same project
            // Console.WriteLine(car.modelVariant);

            Console.WriteLine(car.year);
        }
    }
}
