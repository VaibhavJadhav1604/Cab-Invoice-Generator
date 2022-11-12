using CIG3;
using NUnit.Framework;

namespace NTest1
{
    public class Tests3
    {

        [Test]
        public void Test3()
        {
            ride r = new ride();
            multiplerides[] mr = { new multiplerides(20, 10), new multiplerides(10, 20) };
            double actual = r.calculatefare(mr);
            double expected = 330;
            Assert.AreEqual(expected, actual);
        }
    }
}