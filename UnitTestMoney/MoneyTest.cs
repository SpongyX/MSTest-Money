using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMoney
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void Money_testingBalance()
        {
            double beginingbalance = 20;
            double removedAmound = 5;
            double expectedResult = 15;
            
            Money money = new Money("Mo", beginingbalance);
            
            money.removeAmount(removedAmound);
            double actual = money.Balance;
            Assert.AreEqual(expectedResult, actual, 0.0001);
        }
    }
}