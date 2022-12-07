using System;

namespace Delegate
{
    //public class Program
    //{
    //    public static string Greeting(string name) {
    //        return $"Hello {name}";
    //    }

    //    public delegate string GreetingDelegate(string name);

    //    static void Main(string[] args) {
    //        GreetingDelegate greetingDelegate = new GreetingDelegate(Program.Greeting);

    //        string greetingMessage = greetingDelegate.Invoke("world");
    //        Console.WriteLine(greetingMessage);
    //    }
    //}



    public class Program
    {
        static void Main(string[] args) {
            Square square = new Square();
            SquareDelegate squareDelegate = new SquareDelegate(square.GetArea);

            //Invoke the unicast delegate
            int valueReturnedByUnicastDelegate = squareDelegate(5);

            Console.WriteLine($"Value returned by unicast delegate: {valueReturnedByUnicastDelegate}");

            // Add another method to the delegate to make it a multicast delegate
            Console.WriteLine();

            squareDelegate += square.GetPerimeter;
            int valueReturnedByMulticastDelegate = squareDelegate(5);

            Console.WriteLine($"Value returned by multicast delegate: {valueReturnedByMulticastDelegate}");
        }
    }
}
