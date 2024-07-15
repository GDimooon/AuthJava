using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BClassLib
{
    internal class BClass
    {
        private string _word;
        private int _numbers1;
        private double _numbers2;
        public string Word { get { return _word; } set { _word = value; } }
        public int Numbers1 { get { return _numbers1; } set { _numbers1 = value; } }
        public double Numbers2 { get { return _numbers2; } set { _numbers2 = value; } }

        public BClass()
        {
            _word = "";
            _numbers1 = 0;
            _numbers2 = 0;
        }

        public BClass(string paraWord, int paraNumbers1, double paraNumbers2)
        {
            _word = paraWord;
            _numbers1 = paraNumbers1;
            _numbers2 = paraNumbers2;
        }
        // Переопределение операций true и false
        public static bool operator true(BClass obj)
        {
            if (obj.Word != "" && obj.Numbers2 > 0 && obj.Numbers1 > 0)
                return true;
            return false;
        }
        public static bool operator false(BClass obj)
        {
            if (obj)
                return false;
            return true;
        }

        // Переопределение операции умножения
        public static BClass operator *(BClass obj1, BClass obj2)
        {
            return new BClass
            {
                Numbers1 = obj1.Numbers1 * obj2.Numbers1,
                Numbers2 = obj1.Numbers2 * obj2.Numbers2,
                Word = String.Concat(Enumerable.Repeat(obj1.Word, obj2.Numbers1))
            };
        }

        // Дополнительная операция: сложение с параметром-строкой
        public static BClass operator +(BClass obj, string str)
        {
            obj.Word += str;
            return obj;
        }

        // Дополнительная операция: вычитание целого параметра
        public static BClass operator -(BClass obj, int num) //=> new BClass
        {
            obj.Numbers2 -= num;
            return obj;

        }
        public override string ToString()
        {
            return "Объект: " + Word + "   Число 1: " + Numbers1.ToString() + "   Число 2: " + (Math.Round(Numbers2, 2)).ToString();
        }
    }
}
