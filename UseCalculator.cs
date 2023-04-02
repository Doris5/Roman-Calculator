namespace RomanCalculator
{
    public class UseCalculator
    {
        private readonly Display _display;
        private readonly Input _input;
        private int _num1;
        private int _num2;
        private string _operation;

        public UseCalculator(Display display, Input input)
        {
            _display = display;
            _input = input;

            DoCalculation();
            
        }

        public void DoCalculation()
        {
            _display.PrintAskForRomanNumerals();

            string[] userInput = _input.GetDigitsFromUser();
            
            _num1 = ConvertRomanToDecimalNumber(userInput[0]);
            _num2 = ConvertRomanToDecimalNumber(userInput[1]);

            _display.PrintAskFromOperator();
            _operation = _input.GetOperatorFromUser();

            GetResult(_operation, _num1, _num2);
        }

        public void GetResult(string operation, int num1, int num2)
        {
            int result = 0;
            if (operation == "+") result = num1 + num2;
            else if (operation == "-") result = num1 - num2;
            else
            {
                _display.PrintInvalidOperation();
                DoCalculation();
            }

            if (result < 1)
            {
                _display.PrintErrorValidation();
                DoCalculation();
            }

            _display.GetResultConsoleMessage(ConvertToRomanNumeral(result));
        }

        public int ConvertRomanToDecimalNumber(string romanNumber)
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

        public int GetRomanNumberValue(char romanSymbol)
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
                    Console.WriteLine($"Case {romanSymbol} is invalid.");
                    DoCalculation();
                    return 0;
            }
        }

        public string ConvertToRomanNumeral(int num)
        {
            if (num < 1 || num > 2001)
            {
                Console.WriteLine($"Cannot convert {num} to Roman numeral.");
                return "";
            }

            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return thousands[num / 1000]
             += hundreds[(num % 1000) / 100]
             += tens[(num % 100) / 10]
             += units[num % 10];


        }

        public void GetResultConsoleMessage(int result)
        {
            Console.WriteLine(ConvertToRomanNumeral(result));
        }
    }
}