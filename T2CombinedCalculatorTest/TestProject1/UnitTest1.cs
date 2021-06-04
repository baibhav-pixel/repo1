using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator obj = new Calculator();
        [TestMethod]
        public void TestMethod1()
        {
            int actual = obj.add(2, 3);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int actual = obj.div(10, 5);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int actual = obj.mul(10, 5);
            int expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int actual = obj.sub(10, 5);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}
