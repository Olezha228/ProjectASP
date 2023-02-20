using NUnit.Framework;

namespace Math.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_WhenPositive_ValidExpected()
        {
            var first = 6;
            var second = 10;

            var result = Calculator.Add(first, second);
            var expected = 16;

            Assert.AreEqual(expected, result);
        }
    }
}