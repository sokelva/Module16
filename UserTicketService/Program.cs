using NUnit.Framework;
using System;

namespace Practices
{
    public class Calculator
    {
        // Main Method
        static public void Main(String[] args)
        {

            Console.WriteLine("Main Method");
        }

        public int Additional(int a, int b)
        {
            return a + b;
        }

        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(100, 10) == 110);
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(100, 10) == 90);
        }

        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(100, 10) == 1000);
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }

        [TestFixture]
        public class CalculatorTests
        {
            [Test]
            public void Division_MustThrowException()
            {
                var calculator = new Calculator();
                Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
            }
        }

    }
}

