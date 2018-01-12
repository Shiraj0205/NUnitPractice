using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitPractice.Fundamentals;

namespace NUnitPractice.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(4, "4")]
        [TestCase(0, "FizzBuzz")]
        public void GetOutput_WhenCalled_RetrunsString(int number, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
