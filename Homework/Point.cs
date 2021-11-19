using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Point : Figure
    {
        public double square;
        public double Square { get { return square; } set { } }
        public virtual double Squere() { return square; }

        public Point( string colourp, State statep) : base(colourp, statep)
        {
            
        }

       



    }
}
