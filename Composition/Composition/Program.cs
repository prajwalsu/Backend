using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args) {
            Honda HondaJazz = new Honda();

            HondaJazz.setColour("Black");

            HondaJazz.setMaxiSpeed(160);

            HondaJazz.carDetails();

            HondaJazz.HondaStart();
        }
    }
}
