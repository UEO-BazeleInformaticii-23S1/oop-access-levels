using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Console.WriteLine(car.modelVariant);
        }
    }
}
