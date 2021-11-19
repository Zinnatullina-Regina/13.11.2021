using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipher
{
    class Program
    {



        static void Main(string[] args)
        {


            ACriper cipher = new ACriper();
            Console.Write("Введите текст: ");
            string message = Console.ReadLine();


            Console.Write("Каким шифром Вы хотите воспользоваться? \nНажмите 1 для шифра ACriper \nНажмите 2 для шифра BCripher\n");

            int vvo;

            while ((!int.TryParse(Console.ReadLine(), out vvo) || vvo > 3 || vvo < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите нужное число");
            }


            if (vvo == 1)
            {
                ACriper coding = new ACriper();
                Console.Write("Что нужно сделать? \nНажмите 1 чтобы зашифровать \nНажмите 2 чтобы расшифровать\n");

                int v;

                while ((!int.TryParse(Console.ReadLine(), out v) || v > 3 || v < 0))
                {
                    Console.WriteLine("Ошибка ввода! Введите нужное число");
                }
                if (v == 1)
                {
                    Console.WriteLine("Зашифрованное сообщение: {0}", coding.encode(message));
                }
                else
                {
                    Console.WriteLine("Расшифрованное сообщение: {0}", coding.decode(message));
                }
            }

            else
            {
                BCripher codless = new BCripher();
                Console.Write("Что нужно сделать? \nНажмите 1 чтобы зашифровать \nНажмите 2 чтобы расшифровать \n");
                int vv;

                while ((!int.TryParse(Console.ReadLine(), out vv) || vv > 3 || vv < 0))
                {
                    Console.WriteLine("Ошибка ввода! Введите нужное число");
                }
                if (vv == 1)
                {
                    Console.WriteLine("Зашифрованное сообщение: {0}", codless.encode(message));
                }
                else
                {
                    Console.WriteLine("Расшифрованное сообщение: {0}", codless.decode(message));
                }
            }








            Console.ReadKey();











        }
    }
}