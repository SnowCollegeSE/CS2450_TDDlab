using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib1;
namespace UnitTest
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void IsPrime()
        {
            Assert.IsTrue(Prime.IsPrime(3), "3 should be prime");
        }
        [DataTestMethod]
        [DataRow(5), DataRow(7), DataRow(11), DataRow(13), DataRow(97)]
        public void IsPrimeParam(int candidate)
        {
            Assert.IsTrue(Prime.IsPrime(candidate), candidate + " Should be Prime!");
        }
    }
}
