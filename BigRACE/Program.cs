using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRACE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGame> games = new List<IGame> { new Beach(), new Fishing(), new Hill(), new Mousetrap(), new Postmen(), new Sea(), new Calmar() };
            string[] Russian = new string[15] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            string[] France = new string[15] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            string[] China = new string[15] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            string[] Ukraine = new string[15] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            foreach (var game in games)
            {
                Team russia = new Team("Россия", Russian, game);
                Team china = new Team("Китай", China, game);
                Team ukraine = new Team("Украина", Ukraine, game);
                Team france = new Team("Франция", France, game);
                russia.PlayGame();
                france.PlayGame();
                china.PlayGame();
                ukraine.PlayGame();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
