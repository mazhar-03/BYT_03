using Part2_CalculatorProject;

namespace Part2_CalculatorTest;

public class Tests
{
public class CalculatorTests
    {
        private readonly Calculator _calcAdd = new Calculator(8, 2, '+');
        private readonly Calculator _calcSub = new Calculator(21, 5, '-');
        private readonly Calculator _calcMul = new Calculator(10, 5, '*');
        private readonly Calculator _calcDiv = new Calculator(7, 3, '/');

        [Test]
        public void TestAddition()
        {
            Assert.That(_calcAdd.Calculate(), Is.EqualTo(10));
        }

        [Test]
        public void TestSubtraction()
        {
            Assert.That(_calcSub.Calculate(), Is.EqualTo(16));
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.That(_calcMul.Calculate(), Is.EqualTo(50));
        }

        [Test]
        public void TestDivision()
        {
            Assert.That(_calcDiv.Calculate(), Is.EqualTo(2.333).Within(0.001));
        }

        [Test]
        public void TestDivisionByZeroThrowsException()
        {
            var calc = new Calculator(8, 0, '/');
            Assert.Throws<DivideByZeroException>(() => calc.Calculate());
        }

        [Test]
        public void TestInvalidOperationThrowsException()
        {
            var calc = new Calculator(5, 5, '%');
            Assert.Throws<InvalidOperationException>(() => calc.Calculate());
        }

        [Test]
        public void TestNegativeNumbersAddition()
        {
            var calc = new Calculator(-5, -3, '+');
            Assert.That(calc.Calculate(), Is.EqualTo(-8));
        }

        [Test]
        public void TestNegativeNumbersSubtraction()
        {
            var calc = new Calculator(-5, -3, '-');
            Assert.That(calc.Calculate(), Is.EqualTo(-2));
        }

        [Test]
        public void TestDecimalNumbers()
        {
            var calc = new Calculator(2.5, 0.5, '*');
            Assert.That(calc.Calculate(), Is.EqualTo(1.25).Within(0.001));
        }

        [Test]
        public void TestLargeNumbers()
        {
            var calc = new Calculator(1_000_000, 2_000_000, '+');
            Assert.That(calc.Calculate(), Is.EqualTo(3_000_000));
        }

        [Test]
        public void TestZeroInMultiplication()
        {
            var calc = new Calculator(0, 100, '*');
            Assert.That(calc.Calculate(), Is.EqualTo(0));
        }
    }
}