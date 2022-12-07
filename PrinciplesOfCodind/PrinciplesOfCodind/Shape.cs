using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesOfCodind
{
    public abstract class Shape
    {
        public abstract double area();
    }

    public class Rectangle:Shape
    {
        private double width1;

        public double Getwidth() {
            return width1;
        }

        public void Setwidth(double value) {
            width1 = value;
        }

        private double height;

        public double GetHeight() {
            return height;
        }

        public void SetHeight(double value) {
            height = value;
        }

        public override double area() {
            return Getwidth() * GetHeight();
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area() {
            return Radius*Radius*Math.PI
        }

    }
}
