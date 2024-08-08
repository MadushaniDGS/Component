using componentGpu;

namespace componentGpu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MsiManufacture msiManufacturer = new MsiManufacture();
            msiManufacturer.AssembleComponent("gpu");
            msiManufacturer.AssembleComponent("Monitor");

            AsusManufacture asusManufacturer = new AsusManufacture();
            asusManufacturer.AssembleComponent("gpu");
            asusManufacturer.AssembleComponent("Monitor");

            Console.ReadLine();
        }
    }
}