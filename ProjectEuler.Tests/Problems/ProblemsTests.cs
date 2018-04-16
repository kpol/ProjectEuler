using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests.Problems
{
    [TestClass]
    public class ProblemsTests
    {
        [TestMethod]
        public void Problem001()
        {
            Assert.AreEqual(233168, new Problem001().Run());
        }

        [TestMethod]
        public void Problem002()
        {
            Assert.AreEqual(4613732UL, new Problem002().Run());
        }

        [TestMethod]
        public void Problem003()
        {
            Assert.AreEqual(6857UL, new Problem003().Run());
        }

        [TestMethod]
        public void Problem023()
        {
            Assert.AreEqual(4179871L, new Problem023().Run());
        }

        [TestMethod]
        public void Problem047()
        {
            Assert.AreEqual(134043UL, new Problem047().Run());
        }
    }
}