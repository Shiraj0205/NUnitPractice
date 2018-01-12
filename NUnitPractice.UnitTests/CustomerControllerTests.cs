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
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnsNotFound()
        {
            var customer = new CustomerController();
            var result = customer.GetCustomer(0);
            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnsOk()
        {
            var customer = new CustomerController();
            var result = customer.GetCustomer(1);
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
