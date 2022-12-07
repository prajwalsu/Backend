using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Address
    {
        public string addressLine, city, state;
        public Address(string addressLine, string city, string state) {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public Address address;//Employee HAS-A Address  
        public Employee(int id, string name, Address address) {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display() {
            Console.WriteLine(id + " " + name + " " +
              address.addressLine + " " + address.city + " " + address.state);
        }
    }
}

