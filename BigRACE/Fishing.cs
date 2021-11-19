using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRACE
{
    class Fishing : IGame
    {
        public void PlayGame()
        {
            Console.WriteLine("Игроки двух команд по очереди выходят с вёдрами полными воды на скользкое бревно. Задача участников донести вёдра на другой конец бревна не расплескав воду. Мешать этому будут участники двух других команд, они, что есть мочи машут вёслами в разные стороны. Та команда, которая донесёт большее количество воды на другой конец бревна и считается победившей.");
        }
    }
}
