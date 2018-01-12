using NUnit.Framework;
using System.Linq;
using NUnitPractice.Fundamentals;

namespace NUnitPractice.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_RetrunsMAx(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }

        //[Test]
        //public void Max_FirstArgumentIsGreater_ReturnsFirstArgument()
        //{
        //    var result = _math.Max(2, 1);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_SecondArgumentIsGreater_ReturnsSecondArgument()
        //{
        //    var result = _math.Max(1, 2);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_BothArgumentsEqual_ReturnsSame()
        //{
        //    var result = _math.Max(1, 1);
        //    Assert.That(result, Is.EqualTo(1));
        //}

    }
}
