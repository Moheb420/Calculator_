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

        [Test]
        public void AddNumberWithTwoParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Add(2, 2), Is.EqualTo(4));

        }


        [Test]
        public void AddNumberWithTwoParameterWithExceptioinThrowFirstParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<Exception>(() => calc.Add(2, -2));

        }

        [Test]
        public void AddNumberWithTwoParameterWithExceptioinThrow2()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<Exception>(() => calc.Add(-2, 2));

        }
        //-------------------------------------------------------------------------------------------------------


        [Test]
        public void SubstractWithTwoParameterr()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Subtract(3, 1), Is.EqualTo(2));

        }



        [Test]
        public void SubtractWithTwoParameterWithExceptioinThrowFirstParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<Exception>(() => calc.Subtract(2, -8));

        }

        [Test]
        public void SubtractNumberWithTwoParameterWithExceptioinSecondParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<Exception>(() => calc.Subtract(-7, 2));

        }




        //-------------------------------------------------------------------------------------------------------

        [Test]
        public void MultiplyWithTwoParameter()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Multiply(2, 4), Is.EqualTo(8));

        }

        [Test]
        public void MultiplyWithTwoParameterWithExceptioinThrowFirstParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<Exception>(() => calc.Multiply(5, -66));

        }

        [Test]
        public void MultiplyNumberWithTwoParameterWithExceptioinSecondParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<Exception>(() => calc.Multiply(-1, 9));

        }


        //-------------------------------------------------------------------------------------------------------


        [Test]
        public void PowerWithTwoParameter()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Power(2, 3), Is.EqualTo(8));
        }
        [Test]
        public void PowerWithTwoParameterWithExceptioinThrowFirstParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<Exception>(() => calc.Power(5, -6));

        }

        [Test]
        public void PowerNumberWithTwoParameterWithExceptioinSecondParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<Exception>(() => calc.Power(-5, 9));

        }


        //-------------------------------------------------------------------------------------------------------
        [Test]
        public void DivideWithTwoParameter()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Divide(4, 2), Is.EqualTo(2));

        }

        [Test]
        public void DivideWithTwoParameterWithExceptioinThrowFirstParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));

        }

        [Test]
        public void DivideNumberWithTwoParameterWithExceptioinSecondParameter()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.Throws<Exception>(() => calc.Divide(-5, 9));

        }

        //----------------------------------------------------------------------------------------
        [Test]
        public void AddNumberWithAccumulator()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(2);
            Assert.That(calc.accumulator, Is.EqualTo(2));

        }

        [Test]
        public void AddNumberWithAccumulatorExceptionThrowLessThanZero()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();

            Assert.Throws<Exception>(() => calc.Add(-2));

        }

        [Test]
        public void AddNumberWithAccumulatorExceptionThrowNumberIsEqualToZero()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();

            Assert.Throws<Exception>(() => calc.Add(0));

        }

        //-------------------------------------------------------------------------------------------------------
        [Test]
        public void SubstractFromAccumulator()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(2);
            calc.Substract(1);
            Assert.That(calc.accumulator, Is.EqualTo(1));

        }

        [Test]
        public void SubtractWithAccumulatorExceptionThrowLessThanZero()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(7);
            Assert.Throws<Exception>(() => calc.Substract(-2));

        }

        [Test]
        public void SubtractWithAccumulatorExceptionThrowNumberIsEqualToZero()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(8);
            Assert.Throws<Exception>(() => calc.Substract(0));

        }


        //-------------------------------------------------------------------------------------------------------
        [Test]
        public void MultiplyWithAccumulator()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(2);
            calc.Multiply(4);
            Assert.That(calc.accumulator, Is.EqualTo(8));

        }

        [Test]
        public void MultiplyWithAccumulatorExceptionThrowLessThanZero()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(7);
            Assert.Throws<Exception>(() => calc.Multiply(-9));

        }

        [Test]
        public void MultiplyWithAccumulatorExceptionThrowNumberIsEqualToZero()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(5);
            Assert.Throws<Exception>(() => calc.Multiply(0));

        }


        //-------------------------------------------------------------------------------------------------------
        [Test]
        public void DivideWithAccumulator()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(32);
            calc.Divide(16);
            Assert.That(calc.accumulator, Is.EqualTo(2));

        }

        [Test]
        public void DivideWithAccumulatorExceptionThrowLessThanZero()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(12);
            Assert.Throws<Exception>(() => calc.Divide(-9));

        }

        [Test]
        public void DivideWithAccumulatorExceptionThrowNumberIsEqualToZero()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(25);
            Assert.Throws<DivideByZeroException>(() => calc.Divide(0));

        }

        //-------------------------------------------------------------------------------------------------------
        [Test]
        public void PowerOfAccumulator()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(2);
            calc.Power(2);
            Assert.That(calc.accumulator, Is.EqualTo(4));
        }


        [Test]
        public void PowerWithAccumulatorExceptionThrowLessThanZero()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(32);
            Assert.Throws<Exception>(() => calc.Power(-19));

        }

        [Test]
        public void PowerWithAccumulatorExceptionThrowNumberIsGreatherThan1000()
        {
            Calculator_.Calculator calc = new Calculator_.Calculator();
            calc.Add(45);
            Assert.Throws<IndexOutOfRangeException>(() => calc.Power(2000));

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