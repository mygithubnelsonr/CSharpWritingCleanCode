using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            CleanCode.MagicNumbers.MagicNumbers magicNumbers = new MagicNumbers.MagicNumbers();
            magicNumbers.RejectDocumentOld("rot");


#if DEBUG
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
#endif

        }
    }
}
