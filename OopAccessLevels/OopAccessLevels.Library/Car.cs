namespace OopAccessLevels.Library
{
    public class Car
    {
        private string manufacturer = "Renault";

        void CarPrintManufacturer()
        {
            // private field accessible from within the class
            Console.WriteLine(manufacturer);
        }
    }
}