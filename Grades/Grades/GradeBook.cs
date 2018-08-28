using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        List<float> grades;         // List of floating point numbers that contains "grades"
        public string Name;         // Name for the gradebook

        // Constructor
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach(float grade in grades)
            {
                // Use built in Math class and it's Max and Min functions to determine whether the current grade is the new highestGrade or lowestGrade
                stats.highestGrade = Math.Max(grade, stats.highestGrade);
                stats.lowestGrade = Math.Min(grade, stats.lowestGrade);

                sum += grade;
            }

            stats.avgGrade = sum / grades.Count;

            return stats;
        }

        // Function that takes in a floating point number called "grade" and adds it to a list of grades using the List classes' built in Add()
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
    }
}
