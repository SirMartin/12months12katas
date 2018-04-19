using NUnit.Framework;

namespace _12meses12katas.Tests
{
    [TestFixture]
    public class JanuaryStringCalculatorTest
    {
        [Test]
        public void StringEmptyShouldBeZero()
        {
            Assert.AreEqual(0, JanuaryStringCalculator.Add(""));
        }

        [Test]
        public void StringWithOnlyOneNumber()
        {
            Assert.AreEqual(1, JanuaryStringCalculator.Add("1"));
            Assert.AreEqual(3, JanuaryStringCalculator.Add("3"));
        }

        [Test]
        public void StringWithTwoNumbersAndColonSeparator()
        {
            Assert.AreEqual(3, JanuaryStringCalculator.Add("1,2"));
            Assert.AreEqual(7, JanuaryStringCalculator.Add("3,4"));
        }

        [Test]
        public void StringWithThreeNumbersAndColonSeparator()
        {
            Assert.AreEqual(6, JanuaryStringCalculator.Add("1,2,3"));
            Assert.AreEqual(17, JanuaryStringCalculator.Add("3,4,10"));
        }

        [Test]
        public void StringWithBreakLines()
        {
            Assert.AreEqual(3, JanuaryStringCalculator.Add("1\n2"));
            Assert.AreEqual(37, JanuaryStringCalculator.Add("3\n,4,\n10,20"));
        }
    }
}
