using NUnit.Framework;
using MyClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProjectMyLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSquareRadius()
        {
            double expected = 94.985;
            var test = new MyLib();
            Assert.AreEqual(expected, test.SquareRadius(5.5));


        }
        [TestMethod]
        public void TestMethodSquareTriangle()
        {
            double expected = 15.998;
            var test = new MyLib();
            Assert.AreEqual(expected, test.SquareTriangle(4,8,9));


        }

        [TestMethod]
        public void TestMethodCheckForSquareness()
        {
            bool expected_false = false;
            bool expected_true = true;
            var test = new MyLib();
            Assert.AreEqual(expected_false, test.SquareTriangle(3, 5, 7));
            Assert.AreEqual(expected_true, test.SquareTriangle(3, 4, 5));


        }




    }
}