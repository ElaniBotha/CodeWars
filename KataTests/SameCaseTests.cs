using CodeWars.Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SameCaseKataTests
{
    [TestClass]
    public class SameCaseTests
    {
        [TestMethod]
        public void TrueTests()
        {
            Assert.AreEqual(1, SameCaseKata.SameCase('a', 'u'));
            Assert.AreEqual(1, SameCaseKata.SameCase('A', 'U'));
            Assert.AreEqual(1, SameCaseKata.SameCase('Q', 'P'));
            Assert.AreEqual(1, SameCaseKata.SameCase('w', 'y'));
            Assert.AreEqual(1, SameCaseKata.SameCase('c', 'm'));
            Assert.AreEqual(1, SameCaseKata.SameCase('N', 'W'));
        }
        [TestMethod]
        public void FalseTests()
        {
            Assert.AreEqual(0, SameCaseKata.SameCase('a', 'U'));
            Assert.AreEqual(0, SameCaseKata.SameCase('A', 'u'));
            Assert.AreEqual(0, SameCaseKata.SameCase('Q', 'p'));
            Assert.AreEqual(0, SameCaseKata.SameCase('w', 'Y'));
            Assert.AreEqual(0, SameCaseKata.SameCase('c', 'M'));
            Assert.AreEqual(0, SameCaseKata.SameCase('N', 'w'));
        }
        [TestMethod]
        public void NotLetters()
        {
            Assert.AreEqual(-1, SameCaseKata.SameCase('a', '*'));
            Assert.AreEqual(-1, SameCaseKata.SameCase('A', '%'));
            Assert.AreEqual(-1, SameCaseKata.SameCase('Q', '1'));
            Assert.AreEqual(-1, SameCaseKata.SameCase('w', '-'));
            Assert.AreEqual(-1, SameCaseKata.SameCase('c', '8'));
            Assert.AreEqual(-1, SameCaseKata.SameCase('N', ':'));
        }
    }
}