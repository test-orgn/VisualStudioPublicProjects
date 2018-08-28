using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    // Test Class must be public in order to run the tests
    [TestClass]
    public class GradeBookTests
    {
        // Similarly, Test Methods must also be public
        [TestMethod]
        public void ComputesHighestGrade()
        {
            // Create a new GradeBook for testing and add some grades to it
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(75);
            book.AddGrade(68);
            book.AddGrade(84);
            book.AddGrade(45);
            book.AddGrade(82);
            book.AddGrade(90);

            // Compute some statistics on the GradeBook and store the results
            GradeStatistics results = book.ComputeStatistics();

            // Check if the highest grade in the results is the correct value (90)
            Assert.AreEqual(results.highestGrade, 90);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(75);
            book.AddGrade(68);
            book.AddGrade(84);
            book.AddGrade(45);
            book.AddGrade(82);
            book.AddGrade(90);

            GradeStatistics results = book.ComputeStatistics();

            Assert.AreEqual(results.lowestGrade, 10);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(75);
            book.AddGrade(68);
            book.AddGrade(84);
            book.AddGrade(45);
            book.AddGrade(82);
            book.AddGrade(90);

            GradeStatistics results = book.ComputeStatistics();

            // Typically with Test methods that check equality, there is a parameter that allows you to check for equality
            // within a specified amount. Here, we want to check equality within 0.01
            Assert.AreEqual(results.avgGrade, 64.85, 0.01);
        }
    }
}
