using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3LoseCouplingP
{
    public class Owner 
    {
        public void start() {
            Console.WriteLine("started the car");
        }
        public void drive() {
            Console.WriteLine("driving the car");
        }
        public void end() {
            Console.WriteLine("ended the car");
        }
    }

    public class BMW
    {
        Owner owner = new Owner();
    }

    public class RR
    {
        Owner owner = new Owner();
    }

    public class BenzAVTR
    {
        Owner owner = new Owner();
    }
}
