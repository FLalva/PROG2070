/*TriangleSolverTest.cs
  Assignment #2 - PROG2070

  Revision History
    Fatima Lalva, 2020.02.12: Created */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FLAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        /// <summary>
        /// Test Method to return an equilateral triangle
        /// I selected this input for my unit case because it is the correct values for an equilateral triangle
        /// so it proves that it can return equilateral when 
        /// receiving 3 of the same number
        /// </summary>
        [Test]
        public void Analyze_Given555_ResultIsEquilateral()
        {
            //Arrange
            int a = 5;
            int b = 5;
            int c = 5;
            string result;

            //Act
            result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(result, "equilateral");
        }

        /// <summary>
        /// Test Method to return an isosceles triangle
        /// I selected this input for my unit case to prove that it can return isosceles when 
        /// receiving 2 of the same numbers and one different number, as these values are correct
        /// for an isosceles triangle
        /// </summary>
        [Test]
        public void Analyze_Given447_ResultIsIsosceles()
        {
            //Arrange
            int a = 4;
            int b = 4;
            int c = 7;
            string result;

            //Act
            result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(result, "isosceles");
        }

        /// <summary>
        /// Test Method to return a scalene triangle
        /// I selected this input for my unit case because these values are
        /// correct for a scalene triangle and it proves that the Analyze method can return scalene when 
        /// receiving 3 different numbers
        /// </summary>
        [Test]
        public void Analyze_Given447_ResultIsScalene()
        {
            //Arrange
            int a = 7;
            int b = 12;
            int c = 15;
            string result;

            //Act
            result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(result, "scalene");
        }

        /// <summary>
        /// Test Method to return 'not a triangle'
        /// I selected this input for my unit case because there should be a case
        /// where the values do not form a triangle
        /// </summary>
        [Test]
        public void Analyze_Given1054_ResultIsNotATriangle()
        {
            //Arrange
            int a = 10;
            int b = 5;
            int c = 4;
            string result;

            //Act
            result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(result, "not a triangle");
        }

        /// <summary>
        /// Test Method to return 'values have to be greater than 0'
        /// I selected this input for my unit case because there should be a case
        /// where the values can form an equilateral triangle, because of the same sides,
        /// but don't because you can't make a valid triangle with 0's
        /// </summary>
        [Test]
        public void Analyze_Given000_ResultIsValuesCantBeZero ()
        {
            //Arrange
            int a = 0;
            int b = 0;
            int c = 0;
            string result;

            //Act
            result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(result, "values have to be greater than 0");
        }

        /// <summary>
        /// Test Method to return 'values have to be greater than 0' when given negative numbers
        /// I selected this input for my unit case because this shouldn't form a triangle and can be a vlaid input
        /// </summary>
        [Test]
        public void Analyze_GivenNegativeNumbers_ResultIsValuesMustBeGreaterThanZero()
        {
            //Arrange
            int a = -4;
            int b = -4;
            int c = -4;
            string result;

            //Act
            result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(result, "values have to be greater than 0");
        }
    }
}
