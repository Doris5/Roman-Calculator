using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RomanCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ReSharper disable once InvalidXmlDocComment
            /// <summary>
            /// It is necessary for us to remember the rules for reading and writing Roman numbers in order to avoid mistakes.Here is a list of the basic rules for Roman numerals.

            ///    Rule 1: When certain numerals are repeated, the number represented by them is their sum. For example, II = 1 + 1 = 2, or XX = 10 + 10 = 20, or, XXX = 10 + 10 + 10 = 30.
            ///    Rule 2: It is to be noted that no Roman numerals can come together more than 3 times.For example, we cannot write 40 as XXXX
            ///    Rule 3: The letters V, L, and D are not repeated.
            ///    Rule 4: Only I, X, and C can be used as subtractive numerals.There can be 6 combinations when we subtract.These are IV = 5 - 1 = 4; IX = 10 - 1 = 9; XL = 50 - 10 = 40; XC = 100 - 10 = 90; CD = 500 - 100 = 400; and CM = 1000 - 100 = 900
            ///    Rule 5: When a Roman numeral is placed after another Roman numeral of greater value, the result is the sum of the numerals.For example, VIII = 5 + 1 + 1 + 1 = 8, or, XV = 10 + 5 = 15,
            ///    Rule 6: When a Roman numeral is placed before another Roman numeral of greater value, the result is the difference between the numerals.For example, IV = 5 - 1 = 4, or, XL = 50 - 10 = 40, or XC = 100 - 10 = 90
            ///    Rule 7: When a Roman numeral of a smaller value is placed between two numerals of greater value, it is subtracted from the numeral on its right.For example, XIV = 10 + (5 - 1) = 14, or, XIX = 10 + (10 - 1) = 19
            ///    Rule 8: To multiply a number by a factor of 1000 a bar is placed over it.
            ///    Rule 9: Roman numerals do not follow any place value system.
            ///    Rule 10: There is no Roman numeral for zero(0).
            /// </summary>
            /// <param name="args"></param>

            Console.WriteLine("Welcome in Roman Calculator!");

            Console.WriteLine("Enter two Roman numerals separated by a space:");

            string userInput = Console.ReadLine().ToUpper();

            string[] numbers = userInput.Split(' ');
            
            int num1 = ConvertRomanToDecimalNumber(numbers[0]);
            int num2 = ConvertRomanToDecimalNumber(numbers[1]);

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            Console.WriteLine("Enter '+' or '-':");
            string operation = Console.ReadLine();
            GetResult(operation, num1, num2);
            static void GetResult(string operation,int num1,int num2)
            {
                switch (operation)
                {
                    case "+":
                        GetResultConsoleMessage(num1 + num2);
                        break;
                    case "-":
                        GetResultConsoleMessage(num1 - num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }
            }
            

            static int ConvertRomanToDecimalNumber(string romanNumber)
            {
                int actualDecimalValue = 0;
                int lastNumber = 0;

                for (int i = romanNumber.Length - 1; i >= 0; i--)
                {
                    int number = GetRomanNumberValue(romanNumber[i]);

                    if (number < lastNumber)
                        actualDecimalValue -= number;
                    else
                        actualDecimalValue += number;

                    lastNumber = number;
                }

                return actualDecimalValue;
            }

            static int GetRomanNumberValue(char romanSymbol)
            {
                switch (romanSymbol)
                {
                    case 'I': return 1;
                    case 'V': return 5;
                    case 'X': return 10;
                    case 'L': return 50;
                    case 'C': return 100;
                    case 'D': return 500;
                    case 'M': return 1000;
                    default:
                        throw new Exception($"Case {romanSymbol} is invalid.");
                        return 0;
                }
            }

            static string ConvertToRomanNumeral(int num)
            {
                if (num < 1 || num > 2001)
                {
                    Console.WriteLine($"Cannot convert {num} to Roman numeral.");
                    return "";
                }

                string[] thousands = { "", "M", "MM" };
                string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

                return thousands[num / 1000]
                 += hundreds[(num % 1000) / 100]
                 += tens[(num % 100) / 10]
                 += units[num % 10];


            }

            static void GetResultConsoleMessage(int result)
            {
                Console.WriteLine(ConvertToRomanNumeral(result));
            }
        }
    }
}