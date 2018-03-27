using System;
using NUnit.Framework;

namespace Tennis.Web.Tests
{
    [TestFixture]
    public class FirstTest
    {
        [Test]
        public void AssertThatProductOfTwoAndTwoEqualsFour()
        {
            Assert.That(2*2, Is.EqualTo(4));
        }
    }
}
