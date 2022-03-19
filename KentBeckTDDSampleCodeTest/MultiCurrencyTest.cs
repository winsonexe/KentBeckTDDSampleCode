using KentBeckTDDSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KentBeckTDDSampleCodeTest
{
    [TestClass]
    public class MultiCurrencyTest
    {
        //5美元*2=10美元
        [TestMethod]
        public void TestDollarMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.Times(2)); 
            Assert.AreEqual(new Dollar(15), five.Times(3));  
        }

        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Times(2)); 
            Assert.AreEqual(new Franc(15), five.Times(3));  
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
