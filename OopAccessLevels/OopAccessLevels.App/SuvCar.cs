using OopAccessLevels.Library;

namespace OopAccessLevels.App
{
    public class SuvCar : Car
    {
        private Wheel aWheel = new Wheel();

        void SuvPrintManufacturer()
        {
            // Car private field not accessible in child class 
            // from another project
            // Console.WriteLine(manufacturer);

            // Car protected field accesssible in child class
            // from another project
            Console.WriteLine(model);

            // Car private-protected field inaccesssible in child class
            // from another project
            // Console.WriteLine(modelVariant);

            Console.WriteLine(year);
        }

        private class SuvWheel : Wheel
        {

        }
    }
}
