using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class EqualityTest
    {
        [TestMethod]
        public void ThisTestWillPass()
        {
            Assert.AreEqual(1, 1);
        }
        
        [TestMethod]
        public void ThisTestWillFail()
        {
            Assert.AreEqual(2, 2);
        }
    }
}
