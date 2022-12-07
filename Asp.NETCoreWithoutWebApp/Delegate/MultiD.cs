using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate int SquareDelegate(int length);

    public class Square
    {
        public int GetArea(int length) {
            int Area = length * length;
            Console.WriteLine($"Area of square: {Area}");
            return Area;
        }

        public int GetPerimeter(int length) {
            int Perimeter = 4 * length;
            Console.WriteLine($"Perimeter of square: {Perimeter}");
            return Perimeter;
        }
    }




}
