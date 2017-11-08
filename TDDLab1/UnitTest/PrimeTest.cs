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
            //Assert.Fail();
            Assert.IsTrue(Prime.IsPrime(3), "3 should be prime");
        }
        [DataTestMethod]
        [DataRow(5), DataRow(7), DataRow(11), DataRow(13), DataRow(97),
            DataRow(67)]
        public void IsPrimeParam(int candidate)
        {
            Assert.IsTrue(Prime.IsPrime(candidate), candidate + " Should be Prime!");
        }

        [TestMethod]
        public void PrimeStringLooksGood()
        {
            Assert.AreEqual("Primes found: 7, 5, 3, 2, 1", Prime.ListPrimesLTEQ(8));

        }

        [DataTestMethod]
        [DataRow(20, "Primes found: 19, 17, 13, 11, 7, 5, 3, 2, 1"),
            DataRow(8, "Primes found: 7, 5, 3, 2, 1"),
            DataRow(40, "Primes found: 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2, 1")]
        public void PrimeStringLooksGoodData(int candidate, string hcAnswer)
        {
            //Assert.AreEqual("Primes found: 7, 5, 3, 2, 1", Prime.ListPrimesLTEQ(candidate));
            Assert.AreEqual(hcAnswer, Prime.ListPrimesLTEQ(candidate));
         
        }

        [DataTestMethod]
        [DataRow(9,true),
            DataRow(10,false)]
        public void IsSquareTest(int candidate, bool myanswer)
        {
            Assert.AreEqual(Prime.IsSquare(candidate),myanswer);
        }

    }
}
