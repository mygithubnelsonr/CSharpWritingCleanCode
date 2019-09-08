namespace CleanCode.SwitchStatements
{
    public class MonthlyStatementsOld
    {
        //public float CallCost { get; set; }
        //public float SMSCost { get; set; }
        //public float TotalCost { get; set; }

        //public void Generate(MonthlyUsage usage)
        //{
        //    switch(usage.Customer.Type)
        //    {
        //        case CustomerType.PayAsYouGo:
        //            CallCost = 0.12f * usage.CallMinutes;
        //            SMSCost = 0.12f * usage.SmsCount;
        //            TotalCost = CallCost + SMSCost;
        //            break;

        //        case CustomerType.Unlimited:
        //            TotalCost = 54.50f;
        //            break;

        //        default:
        //            throw new NotImplementedException("The current customer is not supported.");

        //    }
        //}

    }

    public class MonthlyStatement
    {
        public float CallCost { get; set; }
        public float SMSCost { get; set; }
        public float TotalCost { get; set; }

    }
}

