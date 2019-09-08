using CleanCode.SwitchStatements;
using System;

namespace CleanCode
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //VariableDeclarationAtTheTop.PayCalculator calculator = new VariableDeclarationAtTheTop.PayCalculator(0);
            //MagicNumbers.MagicNumbers magicNumbers = new MagicNumbers.MagicNumbers();
            //magicNumbers.RejectDocumentOld("rot");

            //Customer customer = new Customer();
            //customer.LoyaltyPoints = 88;
            //DateTime date = DateTime.Now;

            ShowPayAsYouGoCustomer();

            ShorUnlimitedCustomer();


#if DEBUG
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
#endif

        }

        static void ShowPayAsYouGoCustomer()
        {
            var payAsYouGoCustomer = new PayAsYouGoCustomer();
            var usage = new MonthlyUsage { CallMinutes = 100, SmsCount = 100 };
            var statement = payAsYouGoCustomer.GenerateStatement(usage);

            var mcc = statement.CallCost;
            var msc = statement.SMSCost;
            var mtc = statement.TotalCost;

            Console.WriteLine($"CustomerType=PayAsYouGo: mvc={mcc}, msc={msc}, mtc={mtc}");
        }

        static void ShorUnlimitedCustomer()
        {
            var unlimitedCustomer = new UnlimitedCustomer();
            var usage = new MonthlyUsage { CallMinutes = 100, SmsCount = 100 };
            var statement = unlimitedCustomer.GenerateStatement(usage);

            var mcc = statement.CallCost;
            var msc = statement.SMSCost;
            var mtc = statement.TotalCost;

            Console.WriteLine($"CustomerType=PayAsYouGo: mvc={mcc}, msc={msc}, mtc={mtc}");
        }

    }
}
