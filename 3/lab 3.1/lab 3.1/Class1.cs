using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace mycalculator
{
    internal class MyCalc1
    {
        protected int _a;
        public int a
        {
            get { return _a; }
            set
            { _a = value; }
        }
        protected double _b;
        public double b
        {
            get { return _b; }
            set
            { _b = value; }
        }

        public double Calculate()
        {
            return _a + _b / (1+_b);
            

        }
    }
}