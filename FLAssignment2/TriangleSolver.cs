/*TriangleSolver.cs
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
    /// <summary>
    /// Class to figure out if and what kind of triangle
    /// </summary>
    public static class TriangleSolver
    {
        /// <summary>
        /// Method to determine type of triangle
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static string Analyze(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.Equals(secondNumber) && secondNumber.Equals(thirdNumber))
            {
                return "equilateral";
            }
            else if (firstNumber.Equals(secondNumber) || secondNumber.Equals(thirdNumber) || thirdNumber.Equals(firstNumber))
            {
                return "isosceles";
            }
            else
            {
                return "scalene";
            }
        }
    }
}
