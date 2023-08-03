using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void NullTest()
        {
            string uname = null;
            string pwd = null;
            string result = "Provide User Name and Password";
            Assert.AreEqual(result, SignInManager.SignIn(uname, pwd));
        }
    }
}
