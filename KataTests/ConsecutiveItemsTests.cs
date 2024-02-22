using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class ConsecutiveItemsTests
    {
        [TestMethod]
        public void MyTest()
        {
            Assert.AreEqual(false, CodeWars.Kata.ConsecutiveItems.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 7));
            Assert.AreEqual(true, CodeWars.Kata.ConsecutiveItems.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 1));
            Assert.AreEqual(true, CodeWars.Kata.ConsecutiveItems.Consecutive(new int[] { 1, 6, 9, -3, 4, -78, 0 }, -3, 4));
        }
    }
    
}
