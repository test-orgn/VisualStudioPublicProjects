using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // After adding the Reference "System.Speech" and adding a "using System.Speech.Synthesis;" statement to the top of this document,
            // we are able to create an instance of the SpeechSynthesizer class and use it's Speak() method to have the synthesizer speak a string input
            //          SpeechSynthesizer synth = new SpeechSynthesizer();
            //          synth.Speak("Hello, this is the grade book program.");

            // Similar to Java, we must create a new GradeBook Object using the 'new' operator aka by using a Constructor
            GradeBook book = new GradeBook();

            book.AddGrade(91);      // We can only call the methods of a class AFTER making a new object of that class
            book.AddGrade(89.5f);   // Decimal numbers are double by default in C#
                                    // We must explicitly convert double to float by adding an "f" after all decimal numbers
            book.AddGrade(75);

            // Create a separate class for "Statistics" and separate it from the GradeBook (which is only for storing the grades)
            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Average Grade", stats.avgGrade);
            WriteResult("Highest Grade", (int)stats.highestGrade);
            WriteResult("Lowest Grade", stats.lowestGrade);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}
