using NUnit.Framework;
using Math;

namespace Math.Tests
{
    public class Tests
    {
        Math calc;
        [SetUp]
        public void Setup()
        {
            calc=new Math();
        }

        [TestCase(1,1,2)]
        [TestCase(1,5,6)]
        public void TestAdd(double a, double b, double result)
        {
            double res = calc.Add(a,b);
            Assert.AreEqual(res,result);
        }

        [TestCase(1,1,0)]
        [TestCase(1,5,-4)]
        public void TestMinus(double a, double b, double result)
        {
            double res = calc.Minus(a,b);
            Assert.AreEqual(res,result);
        }

    }
}