using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public enum State
    {
        Vision = 1,
        Unvision
    }
    abstract class Figure 
    {

        
        private string colour;
        private State state;

        
        public string Colour { get { return colour; } set { } }
       
        public State State { get { return state; } set { } }
        

        public Figure ( string colour, State state)
        {
           
            this.colour = colour;
            this.state = state;


        }

        public  void ShowInformation ()
        {
            Console.WriteLine(" Colour {0}, State {1}", colour, state );
        }


        public void ShowInformation( double Square)
        {
            Console.WriteLine("Colour {0}, State {1}, Square {2}", Colour, State, Square);
        }



    }
}
