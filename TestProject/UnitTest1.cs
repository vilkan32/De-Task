using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.True(false);
        }

        public void Test2()
        {
            Assert.True(true);
        }
    }
}