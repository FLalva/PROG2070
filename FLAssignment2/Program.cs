/*FLAssignment2.sln
  Assignment #2 - PROG2070

  Revision History
    Fatima Lalva, 2020.02.12: Created */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAssignment2
{
    class Program
    {
        /// <summary>
        /// Method for displaying the menu
        /// </summary>
        public static void DisplayingMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");
        }

        /// <summary>
        /// Method to validate dimensions
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int ValidatingDimensions(string input)
        {
            int digit;

            if (int.TryParse(input, out digit))
            {
                if (digit < 1)
                {
                    Console.WriteLine("Dimension must be greater than zero, enter another number");
                    string otherInput = Console.ReadLine();
                    return ValidatingDimensions(otherInput);
                }
                else
                {
                    return digit;
                }
            }
            else
            {
                Console.WriteLine("Dimension must be an integer, enter another number");
                string otherInput = Console.ReadLine();
                return ValidatingDimensions(otherInput);
            }
        }

        static void Main(string[] args)
        {
            string menuSelection;
            bool repeat = true;
            
            string firstDimension;
            string secondDimension;
            string thirdDimension;

            int firstNumber;
            int secondNumber;
            int thirdNumber;

            do
            {
                DisplayingMenu();
                menuSelection = Console.ReadLine();

                switch (menuSelection)
                {
                    case "1":
                        Console.WriteLine("Enter first dimension of triangle");
                        firstDimension = Console.ReadLine();
                        firstNumber = ValidatingDimensions(firstDimension);
                        Console.WriteLine("Enter second dimension of triangle");
                        secondDimension = Console.ReadLine();
                        secondNumber = ValidatingDimensions(secondDimension);
                        Console.WriteLine("Enter third dimension of triangle");
                        thirdDimension = Console.ReadLine();
                        thirdNumber = ValidatingDimensions(thirdDimension);

                        /////////////Debugging, delete later
                        Console.WriteLine($"Your triangle dimensions are: {firstNumber}, {secondNumber}, {thirdNumber}");
                        //check if triangle can form a trianlge, if so what kind of triangle
                        break;

                    case "2":
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Please select 1 or 2");
                        break;
                }
            } while (repeat);
        }
    }
}
