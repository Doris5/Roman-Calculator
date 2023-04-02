using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{
    public class Input
    {
        public RomanCalculator.MenuSelection GetInputChoice(Display displayCalculatorMenu)
        {
            Console.WriteLine("Welcome in Roman Calculator!");
            var choice = displayCalculatorMenu.PrintCalculatorMenu();
            switch (choice)
            {
                case "1":
                    return RomanCalculator.MenuSelection.NewCalc;
                case "2":
                    return RomanCalculator.MenuSelection.Quit;
                default:
                    Console.WriteLine("Invalid number");
                    Console.WriteLine("Try again!");
                    GetInputChoice(displayCalculatorMenu);
                    return RomanCalculator.MenuSelection.NewCalc;
            }
        }

        public string[] GetDigitsFromUser()
        {
        string userInput = Console.ReadLine().ToUpper();

        string[] numbers = userInput.Split(' ');
        return numbers;
        }

        public string GetOperatorFromUser()
        {
            return Console.ReadLine();
        }
    }
}
