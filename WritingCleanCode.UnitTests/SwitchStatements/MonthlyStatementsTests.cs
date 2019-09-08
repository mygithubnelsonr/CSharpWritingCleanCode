using CleanCode.SwitchStatements;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WritingCleanCode.UnitTests
{
    [TestClass]
    public class MonthlyStatementsTests
    {
        [TestMethod]
        public void PayAsYouGoCustomer_IsChargedBasedOnTheSumOfCostOfCallAndSms()
        {
            var customer = new PayAsYouGoCustomer();
            var usage = new MonthlyUsage { CallMinutes = 100, SmsCount = 100 };
            var statement = customer.GenerateStatement(usage);

            Assert.AreEqual(12.0f, statement.CallCost);
            Assert.AreEqual(12.0f, statement.SMSCost);
            Assert.AreEqual(24.0f, statement.TotalCost);
        }

        [TestMethod]
        public void UnlimitedCustomer_IsChargedAFlatRatePerMonth()
        {
            var customer = new UnlimitedCustomer();
            var usage = new MonthlyUsage { CallMinutes = 100, SmsCount = 100 };
            var statement = customer.GenerateStatement(usage);

            Assert.AreEqual(0, statement.CallCost);
            Assert.AreEqual(0, statement.SMSCost);
            Assert.AreEqual(54.90f, statement.TotalCost);
        }
    }
}
