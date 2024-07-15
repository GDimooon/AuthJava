using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.3. Вариант 13.");

            double Xn = 0, Xk = 0, h = 0, Yx = 0, Sx = 0, factorial = 1, x = 0;
            Console.WriteLine("Введите значение Xn");
            Xn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Xk");
            Xk = Convert.ToDouble(Console.ReadLine());
            h = (Xk - Xn) / 10;
            Yx = 2 * (Math.Cos(Xn) * Math.Cos(Xn) - 1);
            x = Xn;
            for (int n = 0; n < 8; n++)
            {
                Sx = Sx + (Math.Pow((-1),n)*Math.Pow(2*Xn,2*n)/ (Factorial(2*n, factorial)));
                x = x + h;
            }
            while (Xn < Xk)
            {
                Console.WriteLine("При Xn = {0},  Yx = {1}, Sx = {2}", Xn, Yx, Sx);
                Xn = Xn + h;
                Console.ReadKey();
            }
        }
        static Double Factorial(double n, double factorial)
        {
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    
    }
}
