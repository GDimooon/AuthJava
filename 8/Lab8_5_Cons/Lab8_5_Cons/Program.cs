using System;
using Lab8_5_Cons;

internal abstract class Program
{
    static void Main(string[] args)
    {
        var date = new Date(1, 1, 2021);

        date.InvalidDate += () => Console.WriteLine("Дата недействительна");
        date.SuspiciousDate += () => Console.WriteLine("Дата подозрительная");

        date.Day = 30;
        date.Month = 13;
        date.Year = 2051;

        date.Day = 29;
        date.Month = 2;
        date.Year = 2001;
    }
}
