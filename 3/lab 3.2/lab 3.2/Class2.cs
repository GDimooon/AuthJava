using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mycalculator1;

namespace mycalculator2
{
    internal class MyCalc2 : MyCalc1
    {

        private double _d;
        public double d
        {
            get { return _d; }
            set
            { _d = Convert.ToDouble(value); }
        }


        private double _c2;
        public double C2
        {
            get { return _c2; }
        }
        public new double Calculate()
        {
            _c2 = 0;

            if (_d < _a)
            { _c2 = _a + _b + _d; }
            else 
                _c2=_a - _b - _d;
            return _c2;
        }
    }
}
