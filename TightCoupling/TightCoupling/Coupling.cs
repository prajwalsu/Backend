using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TightCoupling
{
    public class A
    {
        public int a = 0;
        public int getA() {
            Console.WriteLine("getA() method");
            return a;
        }
        public void setA(int aa) {
            if (!(aa > 10))
                a = aa;
        }
    }

}
