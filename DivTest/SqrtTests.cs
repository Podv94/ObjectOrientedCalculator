using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void CalculateTest()
        {
            Sqrt calculator = new Sqrt();
            Assert.AreEqual(5, calculator.Calculate(25));
            Assert.AreEqual(3, calculator.Calculate(9));
        }
    }
}