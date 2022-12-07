using System;

namespace LooseCoupling
{
    class Program
    {
        static void Main(string[] args) {
            A aObject = new A();
            aObject.setA(100); // No way to set 'a' to such value as this method call will
                               // fail due to its enforced rule.
            Console.WriteLine("aObject value is: " + aObject.getA());
        }
    }
}
//the code that is defined by this kind of implementation uses loose coupling and
//is recommended since class B has to go through class A to get its state where
//rules are enforced. If class A is changed internally, class B will not break as
//it uses only class A as a way of communication.