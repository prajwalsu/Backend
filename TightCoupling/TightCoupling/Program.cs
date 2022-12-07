using System;

namespace TightCoupling
{
    class Program
    {
        static void Main(string[] args) {
            A aObject = new A();
            aObject.a = 100; // Not suppose to happen as defined by class A, this causes tight coupling.
            Console.WriteLine("aObject.a value is: " + aObject.a);
        }
    }
    }

//In the above example, the code that is defined by this kind of implementation uses tight coupling
  //  and is very bad since class B knows about the detail of class A, if class A changes the 
    //variable 'a' to private then class B breaks, 
   // also class A's implementation states that variable 'a ' should not be more than 10 