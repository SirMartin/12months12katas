using NUnit.Framework;

namespace _12meses12katas.Tests
{
    [TestFixture]
    public class FebruaryRomanCalculatorTest
    {
        [Test]
        public void OnlySingleUnitTest()
        {
            Assert.That("I" == FebruaryRomanCalculator.Calculate(1));
            Assert.That("V" == FebruaryRomanCalculator.Calculate(5));
        }

        [Test]
        public void MultipleUnitTest()
        {
            Assert.That("II" == FebruaryRomanCalculator.Calculate(2));
            Assert.That("III" == FebruaryRomanCalculator.Calculate(3));
        }

        [Test]
        public void UnitsAndTensTest()
        {
            Assert.That("X" == FebruaryRomanCalculator.Calculate(10));
            Assert.That("XV" == FebruaryRomanCalculator.Calculate(15));
            Assert.That("XVIII" == FebruaryRomanCalculator.Calculate(18));
            Assert.That("LII" == FebruaryRomanCalculator.Calculate(52));
            Assert.That("LXVII" == FebruaryRomanCalculator.Calculate(67));
        }

        [Test]
        public void UnitsTensHundredsTest()
        {
            Assert.That("CX" == FebruaryRomanCalculator.Calculate(110));
            Assert.That("CXV" == FebruaryRomanCalculator.Calculate(115));
            Assert.That("CXVIII" == FebruaryRomanCalculator.Calculate(118));
        }

        [Test]
        public void UnitsWithSubstractionTest()
        {
            Assert.That("IX" == FebruaryRomanCalculator.Calculate(9));
        }

        [Test]
        public void FullNumbersWithSubstractionTest()
        {
            Assert.That("DCLXXXIV" == FebruaryRomanCalculator.Calculate(684));
            Assert.That("MCMXCIII" == FebruaryRomanCalculator.Calculate(1993));
            Assert.That("MCMXCIX" == FebruaryRomanCalculator.Calculate(1999));
        }

        [Test]
        public void FinalTest()
        {
            Assert.That("MCMXC" == FebruaryRomanCalculator.Calculate(1990));
            Assert.That("MMVIII" == FebruaryRomanCalculator.Calculate(2008));
        }
    }
}
