using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SockMerchant;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       public void TestMethod1()
        {
            sockPairs sock = new sockPairs();
            List<int> sockList = new List<int>()
            {1, 1, 2, 2, 3};
            int actual = sock.findDuplicates(sockList);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod2()
        {
            sockPairs sock = new sockPairs();
            List<int> sockList = new List<int>()
            {1, 1, 2, -4, 3};
            int actual = sock.findDuplicates(sockList);
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod3()
        {
            sockPairs sock = new sockPairs();
            List<int> sockList = new List<int>()
            {0,0,0,0,0};
            int actual = sock.findDuplicates(sockList);
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod4()
        {
            sockPairs sock = new sockPairs();
            List<int> sockList = new List<int>()
            {0, -1, 2, 4, 3};
            int actual = sock.findDuplicates(sockList);
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod5()
        {
            sockPairs sock = new sockPairs();
            int actual = sock.totalSocks(5);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

    }

}
