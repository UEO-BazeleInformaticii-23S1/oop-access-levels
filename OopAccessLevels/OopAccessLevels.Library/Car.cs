namespace OopAccessLevels.Library
{
    public class Car
    {
        private string manufacturer = "Renault";
        protected string model = "Clio";
        private protected string modelVariant = "BaseModel";


        void CarPrintManufacturer()
        {
            // private field accessible from within the class
            Console.WriteLine(manufacturer);

            // protected field accessible from within the class
            Console.WriteLine(model);

            // private-protected field accessible from within the class
            Console.WriteLine(modelVariant);
        }
    }
}