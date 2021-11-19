using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> Points = new List<Point>();
            List<circle> circles = new List<circle>();
            List<Rectangle> Rectangles = new List<Rectangle>();






            bool dofigure = true;
            while (dofigure)
            {
                Console.WriteLine("\nЧто вы хотите создать?\nНажмите 1 чтобы создать точку \nНажмите 2 чтобы создать круг\nНажмите 3 чтобы создать прямоугольник\nЧтобы закрыть программу нажмите 4");
                int vvo;
               

                while ((!int.TryParse(Console.ReadLine(), out vvo) || vvo > 5 || vvo < 0))
                {
                    Console.WriteLine("Ошибка ввода! Введите нужное число");
                }
                switch (vvo)
                {
                    case 1:
                        int numpoi = 0;
                        Console.WriteLine("Введите цвет");
                        string colourm = Console.ReadLine();
                        Console.WriteLine("Какой Вы хотите сделать точку? \nНажмите 1 чтобы сделать точку видимой\nНажмите 2 чтобы сделать ее невидимой\n");
                        int n;
                        while ((!int.TryParse(Console.ReadLine(), out n) || n > 3 || n < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        State tip = (State)(n);
                        Points.Add(new Point(colourm,tip));
                        
                        Console.WriteLine("Ваша точка:");
                        Points[numpoi].ShowInformation();
                        numpoi++;
                        break;

                    case 2:

                        int numcir = 0;
                       
                        Console.WriteLine("Введите радиус");
                        double r;
                        while ((!double.TryParse(Console.ReadLine(), out r) || r < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("Введите цвет");
                        colourm = Console.ReadLine();
                        Console.WriteLine("Каким Вы хотите сделать круг? \nНажмите 1 чтобы сделать видимым\nНажмите 2 чтобы сделать невидимым\n");
                        int ni;
                        while ((!int.TryParse(Console.ReadLine(), out ni) || ni > 3 || ni < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        tip = (State)(ni);
                        circles.Add(new circle(r,colourm, tip));
                       
                        Console.WriteLine("Ваш круг:");
                        circles[numcir].ShowInformation(circles[numcir].Squere());
                        numcir++;

                        break;

                    case 3:


                        int numret = 0;
                        Console.WriteLine("Введите 1 сторону");
                        double a;
                        while ((!double.TryParse(Console.ReadLine(), out a) || a < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("Введите 2 сторону");
                        double b;
                        while ((!double.TryParse(Console.ReadLine(), out b) || b < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("Введите цвет");
                        colourm = Console.ReadLine();
                        Console.WriteLine("Каким Вы хотите сделать прямоугольник? \nНажмите 1 чтобы сделать видимым\nНажмите 2 чтобы сделать невидимым\n");
                        int niv;
                        while ((!int.TryParse(Console.ReadLine(), out niv) || niv > 3 || niv < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        tip = (State)(niv);
                        Rectangles.Add(new Rectangle(a, b, colourm, tip));
                       
                        Console.WriteLine("Ваш прямоугольник:");
                        Rectangles[numret].ShowInformation(Rectangles[numret].Squere());
                        numret++;
                        break;


                    case 4:
                        dofigure = false;
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}
