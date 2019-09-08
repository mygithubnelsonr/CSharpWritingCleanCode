namespace CleanCode.SwitchStatements
{
    public class PayAsYouGoCustomer : Customer
    {
        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var statement = new MonthlyStatement();

            statement.CallCost = 0.12f * monthlyUsage.CallMinutes;
            statement.SMSCost = 0.12f * monthlyUsage.SmsCount;
            statement.TotalCost = statement.CallCost + statement.SMSCost;

            return statement;
        }
    }
}