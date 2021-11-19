using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework
{
    class circle : Point
    {
        private double Radi;
        public double Rad 
        {
            get { return Radi; }
            set { }
        }
        public override double Squere()
        {
           square = Radi * Radi * Math.PI;
            return square;
        }
        public circle(double rad, string colourc, State statec): base ( colourc, statec) 
        {
            this.Radi = rad;
        }



       
        
       






    }
}
