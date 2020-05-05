using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void silnia()
        {
            silnia s = new silnia(0);
            Assert.AreEqual(s.oblicz(), 1);

            silnia s1 = new silnia(1);
            Assert.AreEqual(s1.oblicz(), 1);

            silnia s2 = new silnia(5);
            Assert.AreEqual(s2.oblicz(), 120);

        }
    }
}
