using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    public class Program
    {
        static void Main(string[] args)
        {
            var uut = new Calculator();
            // Test Add()
            Console.WriteLine("Add({0}, {1}) = {2}", 3.5, 2.5, uut.Add(8.5, 2.5));
            Console.WriteLine("Add({0}, {1}) = {2}", -3.5, 2.5, uut.Add(-5.5, 6.5));
            Console.WriteLine("Add({0}, {1}) = {2}", -3.5, -2.5, uut.Add(-7.5, -12.5));

            // Test Subtract()
            Console.WriteLine("Subtract({0}, {1}) = {2}", 3.5, 2.5, uut.Subtract(30.5, 22.5));
            Console.WriteLine("Subtract({0}, {1}) = {2}", -3.5, 2.5, uut.Subtract(-31.5, 21.5));
            Console.WriteLine("Subtract({0}, {1}) = {2}", -3.5, -2.5, uut.Subtract(-4.5, -2.5));

            // Test Multiply()
            Console.WriteLine("Multiply({0}, {1}) = {2}", 3.5, 2.5, uut.Multiply(5.5, 9.5));
            Console.WriteLine("Multiply({0}, {1}) = {2}", -3.5, 2.5, uut.Multiply(-3.5, 2.5));
            Console.WriteLine("Multiply({0}, {1}) = {2}", -3.5, -2.5, uut.Multiply(-7.5, -2.5));

            // Test Power()
            Console.WriteLine("Power({0}, {1}) = {2}", 2.0, 3.0, uut.Power(5.0, 3.0));
            Console.WriteLine("Power({0}, {1}) = {2}", -2.0, 3.0, uut.Power(-2.0, 9.0));
            Console.WriteLine("Power({0}, {1}) = {2}", -2.0, -3.0, uut.Power(-3.0, -3.0));

        }
    }
}
