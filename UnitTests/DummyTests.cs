using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DummyTests
    {
        [TestMethod]
        public void Assert_IsTrue_Succeeds()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Assert_Fail_Fails()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void Assert_Inconclusive_IsInconclusive()
        {
            Assert.Inconclusive();
        }
    }
}
