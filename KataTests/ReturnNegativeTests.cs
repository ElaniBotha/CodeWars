using CodeWars.Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class ReturnNegativeTests
    {
        [TestMethod]
        public void PositiveToNegativeTests()
        {
            Assert.AreEqual(-42, ReturnNegativeKata.MakeNegative(42));
            Assert.AreEqual(-5, ReturnNegativeKata.MakeNegative(5));
            Assert.AreEqual(-1000, ReturnNegativeKata.MakeNegative(1000));
        }

        [TestMethod]
        public void ZeroTests()
        {
            Assert.AreEqual(0, ReturnNegativeKata.MakeNegative(0));
        }

        [TestMethod]
        public void NegativeToNegativeTests()
        {
            Assert.AreEqual(-42, ReturnNegativeKata.MakeNegative(-42));
            Assert.AreEqual(-412, ReturnNegativeKata.MakeNegative(-412));
        }
    }
}
