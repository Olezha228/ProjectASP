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
            var second = 11;

            var result = Calculator.Add(first, second);
            var expected = 17;

            Assert.AreEqual(expected, result);
        }
    }
}