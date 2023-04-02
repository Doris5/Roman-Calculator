using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{
    public class Display
    {
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
            Console.WriteLine("Enter two Roman numerals separated by a space:");
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
    }
}
