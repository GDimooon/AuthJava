
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.3. Вариант 13.");

            double Xn = 0, Xk = 0, h = 0, Yx = 0;
            Console.WriteLine("Задание: по заданным значениям Xn и Xk вывести значения X и Y c шагом h = (Xk - Xn) / 10");
            Console.WriteLine("Введите значение Xn");
            Xn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Xk");
            Xk = Convert.ToDouble(Console.ReadLine());
            h = (Xk - Xn) / 10;
            Yx = 2*(Math.Cos(Xn)* Math.Cos(Xn)-1);
            while (Xn < Xk)
            {
                Console.WriteLine("При Xn = {0},  Yx = {1}", Xn, Yx);
                Xn = Xn + h;
                Console.ReadKey();
            }
        }
    }
}
