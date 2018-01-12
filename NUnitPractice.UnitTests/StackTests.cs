using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPractice.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_AddNonNullObject_AddsObjecttoStack()
        {
            var stack = new Stack<string>();
            stack.Push("Hello");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Push_AddNullObject_ThrowsArgumentNullException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Pop_AddNonNullObject_ReturnsFirstItemFromList()
        {
            var stack = new Stack<string>();
            stack.Push("Hello1");
            stack.Push("Hello2");

            var poppedItem = stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(1));
            Assert.That(poppedItem, Is.EqualTo("Hello2"));
        }

        [Test]
        public void Pop_BlankList_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Peek_AddListItem_ReturnsFirstItemFromList()
        {
            var stack = new Stack<string>();
            stack.Push("Hello1");
            stack.Push("Hello2");

            var poppedItem = stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(2));
            Assert.That(poppedItem, Is.EqualTo("Hello2"));
        }

        [Test]
        public void Peek_BlankList_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Peek(), Throws.Exception.TypeOf<InvalidOperationException>());
        }
    }
}
