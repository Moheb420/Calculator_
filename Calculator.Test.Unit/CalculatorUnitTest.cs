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
        public void SubstractWithTwoParameterr()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Subtract(3, 1), Is.EqualTo(2));

        }

        [Test]
        public void MultiplyWithTwoParameter()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Multiply(2,4), Is.EqualTo(8));

        }

        [Test]
        public void PowerWithTwoParameter()
        {

            Calculator_.Calculator calc = new Calculator_.Calculator();
            Assert.That(calc.Power(2,3), Is.EqualTo(8));
        }

        //[Test]
        //public void DivideWithTwoParameter()
        //{

        //    Calculator_.Calculator calc = new Calculator_.Calculator();
        //    Assert.That(calc.Divide(4, 2), Is.EqualTo(2));

        //}

        //----------------------------------------------------------------------------------------
        //[Test]
        //public void AddNumberWithAccumulator()
        //{

        //    Calculator_.Calculator calc = new Calculator_.Calculator();
        //    calc.Add(2);
        //    Assert.That(calc.accumulator, Is.EqualTo(2));

        //}

        //[Test]
        //public void SubstractFromAccumulator()
        //{

        //    Calculator_.Calculator calc = new Calculator_.Calculator();
        //    calc.Add(2);
        //    calc.Substract(1);
        //    Assert.That(calc.accumulator, Is.EqualTo(1));

        //}

        //[Test]
        //public void MultiplyWithAccumulator()
        //{

        //    Calculator_.Calculator calc = new Calculator_.Calculator();
        //    calc.Add(2);
        //    calc.Multiply(4);
        //    Assert.That(calc.accumulator, Is.EqualTo(8));

        //}


        //[Test]
        //public void DivideWithAccumulator()
        //{

        //    Calculator_.Calculator calc = new Calculator_.Calculator();
        //    calc.Add(32);
        //    calc.Divide(16);
        //    Assert.That(calc.accumulator, Is.EqualTo(2));

        //}

        //[Test]
        //public void PowerOfAccumulator()
        //{

        //    Calculator_.Calculator calc = new Calculator_.Calculator();
        //    calc.Add(2);
        //    calc.Power(2);
        //    Assert.That(calc.accumulator, Is.EqualTo(4));
        //}

        //[Test]
        //public void ClearAccumulator()
        //{

        //    Calculator_.Calculator calc = new Calculator_.Calculator();
        //    calc.Add(12);
        //    calc.clear();
        //    Assert.That(calc.accumulator, Is.EqualTo(0));
        //}
    }
}