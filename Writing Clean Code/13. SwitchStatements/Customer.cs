namespace CleanCode.SwitchStatements
{
    public class CustomerOld
    {
        //public int TotalOrders { get; internal set; }
        //public int LoyaltyPoints { get; internal set; }
        //public CustomerType Type { get; set; }

        //public bool IsGoldCustomer()
        //{
        //    return LoyaltyPoints > 100;
        //}

        //public MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        //{
        //    var statement = new MonthlyStatement();

        //    switch(Type)
        //    {
        //        case CustomerType.PayAsYouGo:
        //            statement.CallCost = 0.12f * monthlyUsage.CallMinutes;
        //            statement.SMSCost = 0.12f * monthlyUsage.SmsCount;
        //            statement.TotalCost = statement.CallCost + statement.SMSCost;
        //            break;

        //        case CustomerType.Unlimited:
        //            statement.TotalCost = 54.90f;
        //            break;

        //        default:
        //            throw new NotImplementedException("The current customer is not supported.");

        //    }

        //    return statement;
        //}
    }

    public abstract class Customer
    {
        public abstract MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage);
    }
}
