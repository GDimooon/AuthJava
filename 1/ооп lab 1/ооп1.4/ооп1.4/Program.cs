using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.4. Вариант 13:");
            Console.WriteLine("Дан массив размера N и целые числа K и L (1 < K <= L <= N).");
            Console.WriteLine("Найти среднее арифметическое всех элементов массива, кроме элементов с номерами от K до L включительно.\n");

            Console.Write("Введите размерность массива N = ");
            int N = Convert.ToInt32(Console.ReadLine());
           
            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите элемент массива mas[{0}] = ", i+1);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("Введите целое число K с какого не суммируется: ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число L до какого не суммируется: ");
            int L = Convert.ToInt32(Console.ReadLine());

            double sum =0;
            double rez;
            for (int i = 0; i < N; i++)
            {
                if (i < K + 1 || i > L)
                {
                    sum += mas[i];              
                }
            }
            rez = Math.Round(sum / (N - (L - K + 1)), 2);
            Console.WriteLine(String.Format("Среднее арифметическое введённых чисел с учётом исключающих = {0}", rez));
            Console.ReadKey();
        }
    }
}
