[TestClass]
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1,1);
        }
    }
}