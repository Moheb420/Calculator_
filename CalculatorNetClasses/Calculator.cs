using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    public class Calculator
    {

        public double Add(double a, double b)
        {
            return a + b;
        }


        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

      
        public double Divide(double dividend, double divisor)
        {
            if (divisor < 0)
            {
                throw new Exception("You can not divide with minus number");
            }
            return dividend / divisor;
        }


        public double accumulator
        {
            get;
            private set;

        }
        public void clear()
        {
            accumulator = 0;
        }

        public double Add(double addend)
        {
            accumulator = accumulator + addend;
            return accumulator;
        }


        public double Substract(double substractor)
        {
            accumulator = accumulator - substractor;
            return accumulator;
        }

        public double Multiply(double multiplier)
        {
            accumulator = accumulator * multiplier;
            return accumulator;
        }


        public double Power(double addend)
        {
            if (addend < 0)
            {
                throw new Exception("You can not have a power with minus number");
            }
            accumulator = Math.Pow(accumulator, addend);
            return accumulator;
        }

        public double Divide(double addend)
        {
            accumulator = (accumulator / addend);
            return accumulator;
        }

    }
}
