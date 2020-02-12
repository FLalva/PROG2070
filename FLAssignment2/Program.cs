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
                    Console.WriteLine("Dimension must be greater than zero");
                }
                else
                {
                    return digit;
                }
            }
            else
            {
                Console.WriteLine("Dimension must be an integer");
            }
            return digit = 0;
        }

        public static bool ValidatingTriangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string menuSelection;
            bool repeat = true;
            
            string firstDimension;
            string secondDimension;
            string thirdDimension;
            string triangleType;

            int firstNumber;
            int secondNumber;
            int thirdNumber;

            bool isTriangle;

            do
            {
                DisplayingMenu();
                menuSelection = Console.ReadLine();

                switch (menuSelection)
                {
                    case "1":
                        //Validate first number
                        Console.WriteLine("Enter first dimension of triangle");
                        firstDimension = Console.ReadLine();
                        firstNumber = ValidatingDimensions(firstDimension);
                        if (firstNumber == 0)
                        {
                            break;
                        }

                        //Validate second number
                        Console.WriteLine("Enter second dimension of triangle");
                        secondDimension = Console.ReadLine();
                        secondNumber = ValidatingDimensions(secondDimension);
                        if (secondNumber == 0)
                        {
                            break;
                        }

                        //validate third number
                        Console.WriteLine("Enter third dimension of triangle");
                        thirdDimension = Console.ReadLine();
                        thirdNumber = ValidatingDimensions(thirdDimension);
                        if (thirdNumber == 0)
                        {
                            break;
                        }

                        //check if check if values can form a triangle
                        isTriangle = ValidatingTriangle(firstNumber, secondNumber, thirdNumber);
                        
                        if (isTriangle)
                        {
                            //What kind of triangle
                            triangleType = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);
                            Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} forms a(n) {triangleType} triangle");
                        }
                        else
                        {
                            Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} do not form a triangle");
                        }

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
