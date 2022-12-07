using System;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args) {
            Address a1 = new Address("G-13, Sec-3", "Noida", "UP");
            Employee e1 = new Employee(1, "Sonoo", a1);
            e1.display();
          
        }
    }
}
