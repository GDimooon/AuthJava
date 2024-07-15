using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myLibrary
{
    public static class myClass
    {
        public static bool Check_double(string str)
        {

            double numeric;
            return double.TryParse(str, out numeric);
        }


        public static bool Check_int(string str)
        {

            int numeric;
            return int.TryParse(str, out numeric);
        }

        public static bool Check_array(string str)
        {

            string[] arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (Check_int(arr[i]) == false)
                    return false;
            }
            return true;
        }
        public static double Part_1_func(double a, double b, double c)
        {
            double S;
            S = 0.5 * 2 * Math.Pow(b, 2) + Math.Exp(c*c)-(a*a)/((a*a)-(b*b));
            return S;
        }

        public static double Part_2_func(double a, double b, double c, double d, double e)
        {
            double sumOfNumbers = 0;
            sumOfNumbers =(a+b+c+e+d)/5;
            return sumOfNumbers;
        }

        public static string[] Part_3_func(double Xn, double Xk, string[] ans)//string Y_str, string S_str, string x_str)
        {
            double f;
            int i = 0;
            double h = (Xk - Xn) / 10;
            double x;
            for (x = Xn; x <= Xk; x += h)
            {
                ans[0] = ans[0] + Convert.ToString(x) + " ";
                ans[1] = ans[1] + Convert.ToString(2 * (Math.Cos(x) * Math.Cos(x) - 1)) + " ";

                double S = 0;
                for (int n = 1; n <= 8; n++)
                {
                    f = 1;
                    for (i = 1; i <= 2 * n; i++)
                    { f = f * i; }
                    S = S + Math.Pow(-1, n) * (Math.Pow(2 * x, 2 * n) / f);
                }
                ans[2] = ans[2] + Convert.ToString(Math.Round(S, 3)) + " ";
            }
            return ans;
        }

        public static (int, int) FindMinMaxElements(int[,] matrix, int n)
        {
            int maxBelowSecondaryDiagonal = int.MinValue;
            int minAboveMainDiagonal = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j) // Ниже побочной диагонали
                    {
                        if (matrix[i, j] > maxBelowSecondaryDiagonal)
                        {
                            maxBelowSecondaryDiagonal = matrix[i, j];
                        }
                    }
                    if (i < j) // Выше главной диагонали
                    {
                        if (matrix[i, j] < minAboveMainDiagonal)
                        {
                            minAboveMainDiagonal = matrix[i, j];
                        }
                    }
                }
            }

            return (maxBelowSecondaryDiagonal, minAboveMainDiagonal);
        }
    }
}