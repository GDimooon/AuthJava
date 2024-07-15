using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class Start
    {
        protected double _a;
        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        protected double _b;
        public double B
        {
            get { return _b; }
            set
            {
                if (value + 1 == 0)
                    throw new Exception("b=0");
                else
                    _b = value;
            }
        }

        protected double _d;
        public double D
        {
            get { return _d; }
            set { _d = value; }
        }

        public double i;

        protected double _r;
        public double r
        {
            get { return _r; }
        }
        public void TaskValue()
        {
            _r = Task1();
        }

        public virtual double Task1()
        {
            return 0;
        }
        public void TaskValue2(double a, double b)
        {
            _r = Task2(a, b);
        }

        public virtual double Task2(double a, double b)
        {
            return 0;
        }
        public virtual string ToString(string name)
        {
            return name + _r;
        }

    }

    public class Class1 : Start
    {
        public override double Task1()
        {
            return (_a - _b) / (_a - 2);
        }

        public override double Task2(double a, double b)
        {
            _b = b;
            A = a;
            return Task1();
        }

        public override string ToString()
        {
            return " a = " + A.ToString() + " b = " + _b.ToString() + " res = " + _r.ToString();
        }

        public override string ToString(string name)
        {
            switch (name)
            {
                case "a=":
                    return A.ToString();
                    break;
                case "b=":
                    return _b.ToString();
                    break;
                case "res=":
                    return _r.ToString();
                    break;

            }
            return ToString();
        }
    }
    public class Class2 : Start
    {
        public override double Task1()
        {
            double row = 0;
            // double[] row = new double[Convert.ToInt32(d)+1];
            for (i = 1; i < D; i++)
            {
                row += i * (_a - _d) / (_a + _d);
            }
            return row;
        }

        public override double Task2(double a, double b)
        {
            double d;
            A = a;
            _b = b;
            return Task1();
        }

        public override string ToString()
        {
            return " a = " + A.ToString() + " b = " + _b.ToString() + " res = " + _r.ToString();
        }

        public override string ToString(string name)
        {
            switch (name)
            {
                case "a=":
                    return A.ToString();
                    break;
                case "b=":
                    return _b.ToString();
                    break;
                case "res=":
                    return r.ToString();
                    break;
            }
            return ToString();
        }
    }

}