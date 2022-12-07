using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args) {



            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            Console.ReadKey();

        }


        
    }
}
