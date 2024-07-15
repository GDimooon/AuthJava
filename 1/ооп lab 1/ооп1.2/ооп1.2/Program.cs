using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.2 Вариант 13:");
            Console.WriteLine("Значения переменных a, b и с (введенных с клавиатуры) поменять местами так, чтобы оказалось a <= b <= c.\n");

            double a, b, c;
            Console.Write("Введите значение a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c = ");
            c = Convert.ToDouble(Console.ReadLine());

            if (c>=b && b>=a) 
            { 
                Console.WriteLine("Вывод значений: a={0}, b={1}, c={2}.", a, b, c);
                System.Console.ReadKey();
            }

            if (c>=a && a>=b)
            {
                Console.WriteLine("Вывод значений: b={0}, a={1}, c={2}.", b, a, c);
                System.Console.ReadKey();
            }

            if (b>=c && c>=a)
            {
                Console.WriteLine("Вывод значений: a={0}, c={1}, b={2}.", a, c, b);
                System.Console.ReadKey();
            }

            if (a>=c && c>=b)
            {
                Console.WriteLine("Вывод значений: b={0}, c={1}, a={2}", b, c, a);
                System.Console.ReadKey();
            }

            if (b>=a && a>=c)
            {
                Console.WriteLine("Вывод значений: c={0}, a={1}, b={2}", c, a, b);
                System.Console.ReadKey();
            }

            if (a>= b && b >=c)
            {
                Console.WriteLine("Вывод значений: c={0}, b={1}, a={2}", c, b, a);
                System.Console.ReadKey();
            }
        }
    }
}

