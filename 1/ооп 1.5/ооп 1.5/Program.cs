using System;
using Laba;


namespace ооп_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int q;
            Console.WriteLine("Лабораторная работа №5, Выполнила: Сапожникова, Группа: ИВТ-22, Вариант 13");
            Console.Write("Введите номер задания(от 1 до 4) : ");
            q = Convert.ToInt32(Console.ReadLine());
            switch (q)
            {
                case 1:
                    Console.WriteLine("Вы выбрали задание 1.1");

                    Console.Write("Введите значение p = ");
                    double p = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение a = ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение b = ");
                    double b = double.Parse(Console.ReadLine());
                    double h = Laba1.Zadanie_1_1(a, b, p);

                    Console.Write("Результат = " + h.ToString("F2"));
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Вы выбрали задание 1.2");
                    Console.WriteLine("Значения переменных a, b и с (введенных с клавиатуры) поменять местами так, чтобы оказалось a <= b <= c.\n");

                    Console.Write("Введите значение a = ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение b = ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение c = ");
                    double c = double.Parse(Console.ReadLine());
                    
                    double e;
                    e = Laba1.Zadanie_1_2(a, b, c);
                    switch (e)
                    {
                        case 1:                         
                            Console.WriteLine("Вывод значений: a={0}, b={1}, c={2}.", a, b, c);
                            System.Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("Вывод значений: b={0}, a={1}, c={2}.", b, a, c);
                            System.Console.ReadKey();
                            break;

                        case 3:
                            Console.WriteLine("Вывод значений: a={0}, c={1}, b={2}.", a, c, b);
                            System.Console.ReadKey();
                            break;

                        case 4:
                            Console.WriteLine("Вывод значений: b={0}, c={1}, a={2}", b, c, a);
                            System.Console.ReadKey();
                            break;

                        case 5:
                            Console.WriteLine("Вывод значений: c={0}, a={1}, b={2}", c, a, b);
                            System.Console.ReadKey();
                            break;

                        case 6:
                            Console.WriteLine("Вывод значений: c={0}, b={1}, a={2}", c, b, a);
                            System.Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("Вы ввели некоректное значение");
                            Console.ReadKey();
                            break;
                    }

                    break;

                case 3:
                    Console.WriteLine("Вы выбрали задание 1.3");

                    double[,] yrov = Laba1.Zadanie_1_3();
                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine("При x = {0},   При Y = {1},   При S = {2}", yrov[i, 0], yrov[i, 1], yrov[i, 2]);
                        Console.ReadKey();
                    }
                    break;
                
                case 4:
                    Console.WriteLine("Вы выбрали задание 1.4");
                    Console.WriteLine("Дан массив размера N и целые числа K и L (1 < K <= L <= N).");
                    Console.WriteLine("Найти среднее арифметическое всех элементов массива, кроме элементов с номерами от K до L включительно.\n");

                    Console.Write("Введите размерность массива N = ");
                    double N = Convert.ToInt32(Console.ReadLine());

                    double[] mas = new double[(int)N];

                    for (int i = 0; i < N; i++)
                    {
                        Console.Write("Введите элемент массива mas[{0}] = ", i + 1);
                        mas[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.Write("Введите целое число K с какого не суммируется: ");
                    double K = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите целое число L до какого не суммируется: ");
                    double L = Convert.ToInt32(Console.ReadLine());

                    double rez = Laba1.Zadanie_1_4(N, K, L, mas);
                    Console.WriteLine("Среднее арифметическое введённых чисел с учётом исключающих = {0}", rez.ToString("F2"));
                    Console.ReadKey();
                    break;

                default:
                    Console.Write("Вы ввели некоректное значение. Вы можете ввести лишь цифры от 1 до 4х");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
