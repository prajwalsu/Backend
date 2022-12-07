using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    class A
    {
        private int a = 0;
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
