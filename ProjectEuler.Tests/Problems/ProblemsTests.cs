using System.Numerics;
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
        public void Problem004()
        {
            Assert.AreEqual(906609, new Problem004().Run());
        }

        [TestMethod]
        public void Problem005()
        {
            Assert.AreEqual(232792560, new Problem005().Run());
        }

        [TestMethod]
        public void Problem006()
        {
            Assert.AreEqual(25164150UL, new Problem006().Run());
        }

        [TestMethod]
        public void Problem007()
        {
            Assert.AreEqual(104743UL, new Problem007().Run());
        }

        [TestMethod]
        public void Problem008()
        {
            Assert.AreEqual(23514624000UL, new Problem008().Run());
        }

        [TestMethod]
        public void Problem009()
        {
            Assert.AreEqual(31875000UL, new Problem009().Run());
        }

        [TestMethod]
        public void Problem010()
        {
            Assert.AreEqual(142913828922UL, new Problem010().Run());
        }

        [TestMethod]
        public void Problem011()
        {
            Assert.AreEqual(70600674, new Problem011().Run());
        }

        [TestMethod]
        public void Problem012()
        {
            Assert.AreEqual(76576500U, new Problem012().Run());
        }

        [TestMethod]
        public void Problem013()
        {
            Assert.AreEqual("5537376230", new Problem013().Run());
        }

        [TestMethod]
        public void Problem014()
        {
            Assert.AreEqual(837799U, new Problem014().Run());
        }

        [TestMethod]
        public void Problem015()
        {
            Assert.AreEqual(new BigInteger(137846528820), new Problem015().Run());
        }

        [TestMethod]
        public void Problem016()
        {
            Assert.AreEqual(1366, new Problem016().Run());
        }

        [TestMethod]
        public void Problem017()
        {
            Assert.AreEqual(21124, new Problem017().Run());
        }

        [TestMethod]
        public void Problem019()
        {
            Assert.AreEqual(171, new Problem019().Run());
        }

        [TestMethod]
        public void Problem020()
        {
            Assert.AreEqual(648, new Problem020().Run());
        }

        [TestMethod]
        public void Problem021()
        {
            Assert.AreEqual(31626L, new Problem021().Run());
        }

        [TestMethod]
        public void Problem022()
        {
            Assert.AreEqual(871198282, new Problem022().Run());
        }

        [TestMethod]
        public void Problem023()
        {
            Assert.AreEqual(4179871L, new Problem023().Run());
        }

        [TestMethod]
        public void Problem025()
        {
            Assert.AreEqual(4782, new Problem025().Run());
        }

        [TestMethod]
        public void Problem027()
        {
            Assert.AreEqual(-59231, new Problem027().Run());
        }

        [TestMethod]
        public void Problem034()
        {
            Assert.AreEqual(40730UL, new Problem034().Run());
        }

        [TestMethod]
        public void Problem035()
        {
            Assert.AreEqual(55, new Problem035().Run());
        }

        [TestMethod]
        public void Problem036()
        {
            Assert.AreEqual(872187, new Problem036().Run());
        }

        [TestMethod]
        public void Problem037()
        {
            Assert.AreEqual(748317UL, new Problem037().Run());
        }

        [TestMethod]
        public void Problem039()
        {
            Assert.AreEqual(840, new Problem039().Run());
        }

        [TestMethod]
        public void Problem046()
        {
            Assert.AreEqual(5777UL, new Problem046().Run());
        }

        [TestMethod]
        public void Problem047()
        {
            Assert.AreEqual(134043UL, new Problem047().Run());
        }

        [TestMethod]
        public void Problem048()
        {
            Assert.AreEqual(new BigInteger(9110846700), new Problem048().Run());
        }

        [TestMethod]
        public void Problem050()
        {
            Assert.AreEqual(997651UL, new Problem050().Run());
        }

        [TestMethod]
        public void Problem095()
        {
            Assert.AreEqual(14316, new Problem095().Run());
        }

        [TestMethod]
        public void Problem179()
        {
            Assert.AreEqual(986262, new Problem179().Run());
        }
    }
}