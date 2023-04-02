using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{
    public class Display
    {
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome in Roman Calculator!");
        }

        public string PrintCalculatorMenu()
        {
            Console.Write("&&& Roman Calculator &&&\n" +
                          "Please choose option\n" +
                          "1. Use Calculator\n" +
                          "2. Quit\n");
            Console.WriteLine();
            return Console.ReadLine();
        }

        public void PrintAskForRomanNumerals()
        {
            Console.WriteLine();
            Console.WriteLine("Enter two Roman numerals between (1-2000) separated by a operator e.g(X - III) :");
            Console.WriteLine();
        }

        public void PrintAskFromOperator()
        {
            Console.WriteLine();
            Console.WriteLine("Enter '+' or '-':");
            Console.WriteLine();
        }

        public void PrintQuitCalculator()
        {
            Console.WriteLine("You quit the calculator. See you soon!");
        }

        public void GetResultConsoleMessage(string result)
        {
            Console.WriteLine();
            Console.WriteLine($"The result of your operation is {result}");
            Console.WriteLine();
        }

        public void PrintInvalidOperation()
        {
            Console.WriteLine("Invalid operation.");
        }

        public void PrintErrorValidation()
        {
            Console.WriteLine("Roman numerals cannot represent zero or negative numbers.");
        }
    }
}
