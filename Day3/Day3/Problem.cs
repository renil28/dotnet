using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Rectangle: Shape
    {
        protected internal double side1;
        protected internal double side2;
    }

    class Circle : Shape
    {
        protected double radius;
    }
    class Shape
    {
        protected Location c;
        public string ToString(string s)
        {
            return s;
        }

        public double Area(double l, double b)
        {
            Rectangle r = new Rectangle();
            r.side1 = l;
            r.side2 = b;
            
            return l * b;
        }
        public static double Area(double r)
        {
            return r * r;
        }

        public double Perimeter(double l, double b)
        {
            return (l + b) * 2;
        }
    }

    class Location : Shape
    {
        private double x;
        private double y;
    }
    internal class Problem
    {
        public static void Main9()
        {
            Shape s = new Shape();
            s.Area(2,3);
            Console.WriteLine();
          
            
        }
    }
}
