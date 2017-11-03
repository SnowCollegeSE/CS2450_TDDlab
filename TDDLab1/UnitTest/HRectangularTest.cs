using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib1;

namespace UnitTest
{
    [TestClass]
    public class HRectangularTest
    {
        [TestMethod]
        public void HRectangularTest1()
        {
            var hRect = new HRectangular(4.0, 5.0);
            var actual = hRect.computeArea();
            Assert.AreEqual(20.0, actual, "4x5 should be 20 area");

        }
    }
}
