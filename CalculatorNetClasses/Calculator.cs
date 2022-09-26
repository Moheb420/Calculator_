using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    public class Calculator
    {


        private double c = 0;

        public double Add(double a, double b) { return a + b; }



        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b); ;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("You can not divide with minus number");
            }

            return dividend / divisor;
        }

        public double squarRoot(double value)
        {
            if (value == 0)
            {
                throw new Exception("Value can not be 0");
            }

            if (value < 0)
            {
                throw new Exception("Value should be greater than 0");
            }


            return accumulator += Math.Sqrt(value);
        }


        public double accumulator
        {
            get;
            private set;

        }
        public void clear()
        {
            if (accumulator == 0)
            {
                throw new Exception("It is already clear");
            }
            accumulator = 0;
        }

        public double Add(double a)
        {
            return accumulator += a;
        }


        public double Substract(double a)
        {
            return accumulator -= a;

        }

        public double Multiply(double a)
        {
            return accumulator *= a;
        }


        public double Power(double a)
        {
            if (a < 0)
            {
                throw new Exception("You can not have a power with minus number");
            }
            else if (a > 1000)
            {
                throw new IndexOutOfRangeException("Too big number! ");
            }
            accumulator = Math.Pow(accumulator, a);
            return accumulator;
        }

        public double Divide(double a)
        {
            if (a > 0)
            {
                accumulator /= a;
            }
            else if (a == 0)
            {
                throw new DivideByZeroException("Cannot muliply number by zero ");
            }

            return accumulator;
        }

    }

}
