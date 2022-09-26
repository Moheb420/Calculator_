using Calculator_;
using Microsoft.VisualStudio.CodeCoverage;

namespace Calculator.Test.Unit
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, 2)]

        [TestCase(5, 3)]

        [TestCase(2, -22)]
        public void AddNumberWithTwoParameter(double a, double b)
        {
            double c = a + b;
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Add(a, b), Is.EqualTo(c));

        }

        //-------------------------------------------------------------------------------------------------------


        [TestCase(2, 2)]

        [TestCase(0, 3)]

        [TestCase(-2, -22)]
        public void SubstractWithTwoParameterr(double a, double b)
        {
            double c = a - b;
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Subtract(a, b), Is.EqualTo(c));

        }

        //-------------------------------------------------------------------------------------------------------

        [TestCase(2, 0)]

        [TestCase(5, -3)]

        [TestCase(-2, -22)]
        public void MultiplyWithTwoParameter(double a, double b)
        {
            double c = a * b;

            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Multiply(a, b), Is.EqualTo(c));

        }


        //-------------------------------------------------------------------------------------------------------

        [TestCase(2, -2)]

        [TestCase(-5, 3)]

        [TestCase(2, 0)]
        public void PowerWithTwoParameter(double a, double b)
        {
            double c = Math.Pow(a, b);
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Power(a, b), Is.EqualTo(c));
        }



        //-------------------------------------------------------------------------------------------------------
        [TestCase(2, 1)]

        [TestCase(-5, 2)]

        [TestCase(2, -2)]
        public void DivideWithTwoParameter(double a, double b)
        {
            double c = a / b;
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Divide(a, b), Is.EqualTo(c));

        }

        [TestCase(2, 0)]
        public void DivideWithTwoParameterWithExceptioinThrowFirstParameter(double a, double b)
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(a, b));

        }


        //----------------------------------------------------------------------------------------
        [TestCase(2)]
        [TestCase(-2)]
        [TestCase(0)]

        public void AddNumberWithAccumulator(double a)
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            double c = calc.Add(a);
            Assert.That(calc.accumulator, Is.EqualTo(c));

        }


        //-------------------------------------------------------------------------------------------------------
        [TestCase(22)]
        [TestCase(-12)]
        [TestCase(0)]
        public void SubstractFromAccumulator(double a)
        {
            double c = 0.0;
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(a);
            c = calc.Substract(a);
            Assert.That(calc.accumulator, Is.EqualTo(c));

        }




        //-------------------------------------------------------------------------------------------------------
        [TestCase(32)]
        [TestCase(-12)]
        [TestCase(3)]
        public void MultiplyWithAccumulator(double a)
        {
            double c = 0.0;
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(a);
            c = calc.Multiply(a);
            Assert.That(calc.accumulator, Is.EqualTo(c));

        }


        //-------------------------------------------------------------------------------------------------------
        [TestCase(22)]
        [TestCase(-2)]
        [TestCase(2)]
        public void DivideWithAccumulator(double a)
        {
            double c = 0.0;
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(a);
            c = calc.Divide(a);
            Assert.That(calc.accumulator, Is.EqualTo(c));

        }

        [TestCase(0)]
        public void DivideWithAccumulatorExceptionThrowNumberIsEqualToZero(double a)
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(2);
            Assert.Throws<DivideByZeroException>(() => calc.Divide(a));

        }

        //-------------------------------------------------------------------------------------------------------
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(2)]
        public void PowerOfAccumulator(double a)
        {
            double c = 0.0;
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(2);
            c = calc.Power(2);
            Assert.That(calc.accumulator, Is.EqualTo(c));
        }


        [TestCase(2000)]
        public void PowerWithAccumulatorExceptionThrowNumberIsGreatherThan1000(double a)
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            double c = calc.Add(a);
            Assert.Throws<IndexOutOfRangeException>(() => calc.Power(c));

        }

        //-------------------------------------------------------------------------------------------------------


        [Test]
        public void SquarRootWithAccumulator()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.squarRoot(4);
            Assert.That(calc.accumulator, Is.EqualTo(2));
        }


        [Test]
        public void SquarRootWithAccumulatorTest1()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(2);
            Assert.Throws<Exception>(() => calc.squarRoot(0));

        }

        [Test]
        public void SquarRootWithAccumulatorTest2()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(45);
            Assert.Throws<Exception>(() => calc.Power(-2));

        }
        //-------------------------------------------------------------------------------------------------------

        [Test]
        public void ClearAccumulator()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(12);
            calc.clear();
            Assert.That(calc.accumulator, Is.EqualTo(0));
        }
        [Test]
        public void TestAccumalator()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(4);
            calc.Substract(4);
            Assert.Throws<Exception>(() => calc.clear());

        }

    }
}