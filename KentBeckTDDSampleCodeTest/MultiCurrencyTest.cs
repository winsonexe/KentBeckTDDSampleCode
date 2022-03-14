using KentBeckTDDSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KentBeckTDDSampleCodeTest
{
    [TestClass]
    public class MultiCurrencyTest
    {
        //5美元*2=10美元
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.AreEqual(10, product.Amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.Amount);
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
