using System;
using ConsoleApp1.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarfetchTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmptyArray()
        {
            Assert.AreEqual(-1, Functions.LongestSequenceOfOneV1(new int[] { }));
        }

        [TestMethod]
        public void TestSingleElementWithOne()
        {
            Assert.AreEqual(-1, Functions.LongestSequenceOfOneV1(new int[] { 1 }));
        }

        [TestMethod]
        public void TestingSingleElementWithZero()
        {
            Assert.AreEqual(-1, Functions.LongestSequenceOfOneV1(new int[] { 0 }));
        }

        [TestMethod]
        public void TestingALotElements()
        {
            Assert.AreEqual(9, Functions.LongestSequenceOfOneV1(new int[] { 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1 }));
        }

        [TestMethod]
        public void TestingALotElements2()
        {
            Assert.AreEqual(4, Functions.LongestSequenceOfOneV1(new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1 }));
        }

        [TestMethod]
        public void TestingALotElements3()
        {
            Assert.AreEqual(4, Functions.LongestSequenceOfOneV1(new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1 }));
        }

        [TestMethod]
        public void TestingAllOnes()
        {
            Assert.AreEqual(-1, Functions.LongestSequenceOfOneV1(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }

        [TestMethod]
        public void TestingAllZeros()
        {
            Assert.AreEqual(-1, Functions.LongestSequenceOfOneV1(new int[] { 0,0,0,0,0}));
        }

        [TestMethod]
        public void TestingALotLotElements()
        {
            Assert.AreEqual(31, Functions.LongestSequenceOfOneV1(new int[] { 0, 0, 0, 0, 0 , 1 , 0 , 1 , 0 , 1 , 0 , 1 , 0 , 1 ,  0 ,1 , 0 , 1 , 1, 1, 0 ,0,0,0,0,0,1,0,1,1,1,0,1,1,0 }));
        }

    }
}
