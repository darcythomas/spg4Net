using System;
using NUnit.Framework;
using spg4Net;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //arrange
            Class1 classsss = new Class1();
            int a = 2;
            int b = 3;
            int expected = 5;
            int actual;

            //Assert
            actual = classsss.test(a, b);


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
