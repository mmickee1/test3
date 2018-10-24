using System;
using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1 ()
        {
            OurClass objet = new OurClass();
            Assert.AreEqual(3, objet.whatever(1, 2));
        }

        [TestMethod]
        public void TestMethod2 ()
        {
            OurClass objet = new OurClass();
            Assert.AreEqual(4, objet.whatever(1, 2));
        }
    }
}
