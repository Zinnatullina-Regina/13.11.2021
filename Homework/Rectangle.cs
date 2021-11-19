using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Rectangle : Point
    {
        private double a;
        private double b;
        public double A { get { return a; } set { } }
        public double B { get { return b; } set { } }


        public Rectangle(double a, double b, string colourc, State statec) : base( colourc, statec)
        {
            this.a = a;
            this.b = b;
        }



        public override double Squere()
        {
            square = a * b;
            return square;
        }


       



    }
}
