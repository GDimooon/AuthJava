using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public static class Laba1
    {
        public static double Zadanie_1_1(double a, double b, double p)
        {
            double h;
            h = p * (p - a) * (p - b) / (a * b);
            return h;
        }

        public static double Zadanie_1_2(double a, double b, double c)
        {
            double e;

            if (c >= b && b >= a)
            {
                e = 1;
                return e;
            }
            if (c >= a && a >= b)
            {
                e = 2;
                return e;
            }
            if (b >= c && c >= a)
            {
                e = 3;
                return e;
            }
            if (a >= c && c >= b)
            {
                e = 4;
                return e;
            }
            if (b >= a && a >= c)
            {
                e = 5;
                return e;
            }
            if (a >= b && b >= c)
            {
                e = 6;
                return e;
            }
            return 0;
        }

        public static double[,] Zadanie_1_3()
        {
            double x, xn, xk, h, Y, f;
            int n, N, i, xi = 0;
            xn = 0;
            xk = 1;
            h = (xk - xn) / 10;
            N = 8;
            double[,] mas = new double[11, 3];

            for (x = xn; x <= xk; x += h)
            {
                double S = 0;
                for (n = 0; n <= N; n++)
                {
                    f = 1;
                    for (i = 1; i <= 2 * n; i++)
                    { f = f * i; }
                    S = S + Math.Pow(-1, n) * (Math.Pow(2*x, 2 * n) / f);
                }
                Y = 2*(Math.Cos(x)*Math.Cos(x)-1);

                mas[xi, 0] = Math.Round(x, 3);
                mas[xi, 1] = Math.Round(Y, 3);
                mas[xi, 2] = Math.Round(S, 3);

                xi++;
            }
            return mas;
        }

        public static double Zadanie_1_4(double N, double K, double L, double[] mas)
        {
            
            double sum = 0;          
            for (int i = 0; i < N; i++)
            {
                if (i < K + 1 || i > L)
                {
                    sum += mas[i];
                }
            }
            double rez;
            rez = sum / (N - (L - K + 1));
            return rez;
        }
    }
}
