namespace OopAccessLevels.Library
{
    public class SedanCar : Car
    {
        void SedanPrintManufacturer()
        {
            // Car private field not accessible in child class 
            // from whithin the same project
            // Console.WriteLine(manufacturer);

            // Car protected field accesssible in child class
            // from within the same project
            Console.WriteLine(model);
        }
    }
}
