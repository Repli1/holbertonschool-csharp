using NUnit.Framework;
using MyMath;

namespace Tests
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
            int result = Operations.Add(2, 2);
            Assert.AreEqual(4, result);
        }

        public void Test2()
        {
            int result = Operations.Add(-2, 2);
            Assert.AreEqual(0, result);
        }

        public void Test3()
        {
            int result = Operations.Add(2, 2);
            Assert.AreEqual(4, result);
        }

        public void Test4()
        {
            int result = Operations.Add(2, 2);
            Assert.AreEqual(4, result);
        }

        public void Test5()
        {
            int result = Operations.Add(2, 2);
            Assert.AreEqual(4, result);
        }

        public void Test6()
        {
            int result = Operations.Add(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}