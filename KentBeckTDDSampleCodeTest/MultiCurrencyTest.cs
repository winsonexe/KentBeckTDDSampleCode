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
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2)); 
            Assert.AreEqual(Money.Dollar(15), five.Times(3));  
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2)); 
            Assert.AreEqual(Money.Franc(15), five.Times(3));  
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsTrue(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Franc(6)));
            //compare franc and dollar will happen?
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [TestMethod]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }
    }
}
