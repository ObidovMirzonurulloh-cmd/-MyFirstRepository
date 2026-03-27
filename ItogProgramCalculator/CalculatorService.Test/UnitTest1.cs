using ItogProgramCalculator;
using NUnit;

namespace CalculatorService.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestAdditional()
        {
            Calculator testAdd = new Calculator();
            Assert.That(testAdd.Additional(5, 6) == 11);


        }

        [Test]
        public void TestSubtraction()
        {
            Calculator testSubtract = new Calculator();
            Assert.That(testSubtract.Subtraction(30, 21) == 9);
        }

        [Test]
        public void TestMultiplication()
        {
            Calculator testMultication = new Calculator();
            Assert.That(testMultication.Miltiplication(30, 10) == 300);
        }

        [Test]
        public void TestDivision()
        {
            Calculator testDivision = new Calculator();
            Assert.That(testDivision.Division(30, 5) == 6);
        }
    }
}