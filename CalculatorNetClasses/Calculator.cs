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
        public double Add(double a, double b)
        {

            if (a > 0 && b > 0)
            {
                c = a + b;
            }
            else if (a < 0 && b > 0)
            {
                throw new Exception("first parameter is less than 0 ");
            }
            else if (a > 0 && b < 0)
            {
                throw new Exception("second parameter is less than 0 ");
            }
            else
            {
                throw new Exception("both parameters are less than 0 ");
            }

            return c;
        }


        public double Subtract(double a, double b)
        {
            if (a > 0 && b > 0)
            {
                c = a - b;
            }
            else if (a < 0 && b > 0)
            {
                throw new Exception("first parameter should be greater than 0 ");
            }
            else if (a > 0 && b < 0)
            {
                throw new Exception("second parameter should be greater than 0 ");
            }
            else
            {
                throw new Exception("both parameters should be greater than 0 ");
            }

            return c;
        }

        public double Multiply(double a, double b)
        {
            if (a > 0 && b > 0)
            {
                c = a * b;
            }
            else if (a < 0 && b > 0)
            {
                throw new Exception("first parameter should be greater than 0 ");
            }
            else if (a > 0 && b < 0)
            {
                throw new Exception("second parameter should be greater than 0 ");
            }
            else
            {
                throw new Exception("both parameters should be greater than 0 ");
            }

            return c;
        }

        public double Power(double a, double b)
        {
            if (a > 0 && b > 0)
            {
                c = Math.Pow(a, b);
            }
            else if (a < 0 && b > 0)
            {
                throw new Exception("first parameter should be greater than 0 ");
            }
            else if (a > 0 && b < 0)
            {
                throw new Exception("second parameter should be greater than 0 ");
            }
            else
            {
                throw new Exception("both parameters should be greater than 0 ");
            }

            return c;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("You can not divide with minus number");
            }

            if (dividend < 0)
            {
                throw new Exception("Nominator should be greater than 0");
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
            if (a > 0)
            {
                accumulator += a;
            }
            else if (a < 0)
            {
                throw new Exception("Cannot add minus numbers");
            }
            else if (a == 0)
            {
                throw new Exception("Number should be greater than 0 ");
            }

            return accumulator;
        }


        public double Substract(double a)
        {
            if (a > 0)
            {
                accumulator = accumulator - a;
            }
            else if (a < 0)
            {
                throw new Exception("Number should be less than 0 ");
            }
            else if (a == 0)
            {
                throw new Exception("The result of substraction is the same as accumalator ");
            }

            return accumulator;

        }

        public double Multiply(double a)
        {
            if (a > 0)
            {
                accumulator *= a;
            }
            else if (a < 0)
            {
                throw new Exception("Number should be less than 0 ");
            }
            else if (a == 0)
            {
                throw new Exception("Cannot muliply number by zero ");
            }

            return accumulator;
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
            else if (a < 0)
            {
                throw new Exception("Number should be less than 0 ");
            }
            else if (a == 0)
            {
                throw new DivideByZeroException("Cannot muliply number by zero ");
            }

            return accumulator;
        }

    }

}
