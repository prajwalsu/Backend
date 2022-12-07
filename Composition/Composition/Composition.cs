using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class CarEngine
    {
        public void StartEngine() {

            Console.WriteLine("The car engine has Started");

        }

        public void stopEngine() {

            Console.WriteLine("The car engine has Stopped");

        }

    }

   public  class Car
    {

        private String colour;

        private int maxi_Speed;

        public void carDetails() {

            Console.WriteLine("Maximum Speed = " + maxi_Speed);
            Console.WriteLine("Car Colour = "+colour);
        }

        //Setting colour of the car

        public void setColour(String colour) {

            this.colour = colour;

        }

        //Setting maximum car Speed

        public void setMaxiSpeed(int maxi_Speed) {

            this.maxi_Speed = maxi_Speed;

        }

    }

    public class Honda:Car {

    public void HondaStart() {

        CarEngine Honda_Engine = new CarEngine(); //composition

        Honda_Engine.StartEngine();
            Honda_Engine.stopEngine();

    }

} 
}
