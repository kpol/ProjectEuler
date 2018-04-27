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
            Assert.AreEqual(104743, new Problem007().Run());
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
        public void Problem018()
        {
            Assert.AreEqual(1074, new Problem018().Run());
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
        public void Problem024()
        {
            Assert.AreEqual(2783915460L, new Problem024().Run());
        }

        [TestMethod]
        public void Problem025()
        {
            Assert.AreEqual(4782, new Problem025().Run());
        }

        [TestMethod]
        public void Problem026()
        {
            Assert.AreEqual(983, new Problem026().Run());
        }

        [TestMethod]
        public void Problem027()
        {
            Assert.AreEqual(-59231, new Problem027().Run());
        }

        [TestMethod]
        public void Problem028()
        {
            Assert.AreEqual(669171001, new Problem028().Run());
        }

        [TestMethod]
        public void Problem029()
        {
            Assert.AreEqual(9183, new Problem029().Run());
        }

        [TestMethod]
        public void Problem030()
        {
            Assert.AreEqual(443839L, new Problem030().Run());
        }

        [TestMethod]
        public void Problem031()
        {
            Assert.AreEqual(73682, new Problem031().Run());
        }

        [TestMethod]
        public void Problem032()
        {
            Assert.AreEqual(45228, new Problem032().Run());
        }

        [TestMethod]
        public void Problem033()
        {
            Assert.AreEqual(100, new Problem033().Run());
        }

        [TestMethod]
        public void Problem034()
        {
            Assert.AreEqual(40730L, new Problem034().Run());
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
        public void Problem038()
        {
            Assert.AreEqual(932718654, new Problem038().Run());
        }

        [TestMethod]
        public void Problem039()
        {
            Assert.AreEqual(840, new Problem039().Run());
        }

        [TestMethod]
        public void Problem040()
        {
            Assert.AreEqual(210, new Problem040().Run());
        }

        [TestMethod]
        public void Problem041()
        {
            Assert.AreEqual(7652413, new Problem041().Run());
        }

        [TestMethod]
        public void Problem042()
        {
            Assert.AreEqual(162, new Problem042().Run());
        }

        [TestMethod]
        public void Problem043()
        {
            Assert.AreEqual(16695334890L, new Problem043().Run());
        }

        [TestMethod]
        public void Problem044()
        {
            Assert.AreEqual(5482660, new Problem044().Run());
        }

        [TestMethod]
        public void Problem045()
        {
            Assert.AreEqual(1533776805, new Problem045().Run());
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
        public void Problem049()
        {
            Assert.AreEqual("296962999629", new Problem049().Run());
        }

        [TestMethod]
        public void Problem050()
        {
            Assert.AreEqual(997651UL, new Problem050().Run());
        }

        [TestMethod]
        public void Problem059()
        {
            Assert.AreEqual(107359, new Problem059().Run());
        }

        [TestMethod]
        public void Problem060()
        {
            Assert.AreEqual(26033, new Problem060().Run());
        }

        [TestMethod]
        public void Problem067()
        {
            Assert.AreEqual(7273, new Problem067().Run());
        }

        [TestMethod]
        public void Problem079()
        {
            Assert.AreEqual("73162890", new Problem079().Run());
        }

        [TestMethod]
        public void Problem087()
        {
            Assert.AreEqual(1097343, new Problem087().Run());
        }

        [TestMethod]
        public void Problem092()
        {
            Assert.AreEqual(8581146, new Problem092().Run());
        }

        [TestMethod]
        public void Problem095()
        {
            Assert.AreEqual(14316, new Problem095().Run());
        }

        [TestMethod]
        public void Problem097()
        {
            Assert.AreEqual(8739992577, new Problem097().Run());
        }

        [TestMethod]
        public void Problem099()
        {
            Assert.AreEqual(709, new Problem099().Run());
        }

        [TestMethod]
        public void Problem104()
        {
            Assert.AreEqual(329468, new Problem104().Run());
        }

        [TestMethod]
        public void Problem112()
        {
            Assert.AreEqual(1587000, new Problem112().Run());
        }

        [TestMethod]
        public void Problem179()
        {
            Assert.AreEqual(986262, new Problem179().Run());
        }

        [TestMethod]
        public void Problem187()
        {
            Assert.AreEqual(17427258, new Problem187().Run());
        }

        [TestMethod]
        public void Problem206()
        {
            Assert.AreEqual(1389019170L, new Problem206().Run());
        }
    }
}