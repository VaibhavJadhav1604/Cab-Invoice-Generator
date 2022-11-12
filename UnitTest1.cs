using CIG1;
using NUnit.Framework;

namespace NTest1
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Fare f=new Fare();
            double actual=f.CalculateFare(10, 20);
            double expected = 120;
            Assert.AreEqual(expected, actual);
        }
    }
}