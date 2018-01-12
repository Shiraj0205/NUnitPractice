using NUnit.Framework;
using System;
using NUnitPractice.Fundamentals;

namespace NUnitPractice.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowsArgumanrNullException(string error)
        {
            var _logger = new ErrorLogger();
            //Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
            Assert.That(() => _logger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Log_ValidError_RaisesErrorLoggedEvent()
        {
            var _logger = new ErrorLogger();

            var id = Guid.Empty;
            _logger.ErrorLogged += (sender, args) => { id = args; };

            _logger.Log("a");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));

        }
    }
}
