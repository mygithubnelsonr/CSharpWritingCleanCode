namespace CleanCode.VariableDeclarationAtTheTop
{
    public class PayCalculator
    {
        private PayFrequency _payFrequentcy;

        public PayCalculator(PayFrequency payFrequency)
        {
            _payFrequentcy = payFrequency;
        }

        public decimal CalcGross(decimal rate, decimal hours)
        {
            decimal overtimeHours = 0;
            decimal regularHours  = 0;

            // decimal regularPay = 0; moved the valriable to the bottom where it is used
            // decimal overtimePay = 0; So what I want you to take away from this lecture 
            // is to declare your variables close to their use it
            // decimal grossPay = 0; so we do the same here

            if(_payFrequentcy == PayFrequency.Fortnightly)
            {
                if(hours > 80)
                {
                    overtimeHours = hours - 80;
                    regularHours = 80;
                }
                else
                    regularHours = hours;
            }
            else if(_payFrequentcy == PayFrequency.Weekly)
            {
                if(hours > 40)
                {
                    overtimeHours = hours - 40;
                    regularHours = 40;
                }
                else
                    regularHours = 40;
            }

            decimal overtimePay = 0;
            if(overtimeHours > 0m)
            {
                overtimePay += (rate * 1.5m) * overtimeHours;
            }

            var regularPay = (regularHours * rate);
            var grossPay = regularPay + overtimePay;

            return grossPay;
        }
    }
}
