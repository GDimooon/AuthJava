using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.1 Вариант 13:");
            Console.WriteLine("Разработайте программу для вычисления заданной функции.");
            Console.WriteLine("Все переменные должны иметь тип double.\n");

            Console.Write("Введите значение p = ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Math.Round(p * (p - a) * (p - b) / (a*b), 2);
            Console.WriteLine("Результат h = {h}");
            System.Console.ReadKey();
        }
    }
}
