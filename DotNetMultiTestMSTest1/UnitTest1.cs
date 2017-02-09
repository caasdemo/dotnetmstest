using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetMultiTestLib;
namespace DotNetMultiTestMSTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SampleLib lib = new SampleLib();
            var result=lib.GetValueByIndex(0);
            Assert.AreEqual("Hello Test", result);
        }
    }
}
