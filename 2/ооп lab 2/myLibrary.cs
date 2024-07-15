using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class myClass 
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
}
