using NUnit.Framework;
using System;
using NUnitPractice.Fundamentals;

namespace NUnitPractice.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        public void CalculateDemeritPoints_SpeedLessThanZero_ThrowArgumentOutOfRangeException()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf< ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_SpeedGreaterThanMax_ThrowArgumentOutOfRangeException()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(301), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_SpeedLessThanEqualToSpeedLimit_ReturnsZero()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var result = demeritPointsCalculator.CalculateDemeritPoints(65);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedWithinSpeedLimit_ReturnsDemeritPoints()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var result = demeritPointsCalculator.CalculateDemeritPoints(80);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}
