using NUnit.Framework;

namespace LogAn.UnitTests
{
    public class MemCalculatorTests
    {
        private static MemCalculator MakeCalc()
        {
            return new MemCalculator();
        }

        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            MemCalculator calc = MakeCalc();
            int lastSum = calc.Sum();
            //            Assert.AreEqual(0, lastSum);
            Assert.That(lastSum, Is.EqualTo(0));
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            MemCalculator calc = MakeCalc();
            calc.Add(1);
            int sum = calc.Sum();
            // Assert.AreEqual(1, sum);
            Assert.That(sum, Is.EqualTo(1));
        }
     }
}
