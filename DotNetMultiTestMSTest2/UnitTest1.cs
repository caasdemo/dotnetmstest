using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetMultiTestLib;
namespace DotNetMultiTestMSTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SampleLib2 lib = new SampleLib2();
            var result = lib.IsValueBiggerthanZero(1);
            Assert.AreEqual(true, result);
        }
    }
}
