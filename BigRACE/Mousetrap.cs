using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRACE
{
    class Mousetrap : IGame
    {
        public void PlayGame()
        {
            Console.WriteLine("Здесь принимают участие по два человека от двух команд. В костюмах мышей поочерёдно они должны миновать препятствия и попасть в большой кусок сыра, расположенный в центре арены. Там они должны взять маленький кусочек сыра и принести его в свой ящик. Сложность в том, что на арене присутствует бык. Выигрывает команда, которая принесёт наибольшее количество сыра.");
        }
    }
}
