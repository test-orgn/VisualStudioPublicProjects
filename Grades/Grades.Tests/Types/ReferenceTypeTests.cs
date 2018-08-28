using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "Darien";
            name.ToUpper();

            Assert.AreEqual(name, "Darien");    // This will pass because calling name.ToUpper() won't change the underlying string

            name = name.ToUpper();

            Assert.AreEqual(name, "DARIEN");    // This will pass because we pointed name to the value returned from name.ToUpper()
        }

        /*
            This method illustrates the immutable types. DateTime is a value type, and is also immutable. Here we can
            see that the DateTime object in step 1 is NOT the same as what is returned in step 2 after calling the AddDays()
            method on the DateTime object. Instead, AddDays() returns a new DateTime object with a different value. The 
            underlying value of a value type cannot be changed once created. So in order to pass the test, we would need to 
            point "date" to the return value of date.AddDays(1)
        */
        [TestMethod]
        public void AddDaysToDateTime()
        {
            // 1)
            DateTime date = new DateTime(2015, 1, 1);

            // 2) WE MUST POINT date TO WHAT IS RETURNED, WE CANNOT SIMPLY CALL date.AddDays(1) and expect the underlying date to 
            // change i.e. the following line will fail:

            // date.AddDays(1);

            date = date.AddDays(1);

            // 3) 
            Assert.AreEqual(date.Day, 2); 
        }

        [TestMethod]
        public void ValueTypesPassedByValue()
        {
            int x = 46;

            IncrementNumber(ref x);

            Assert.AreEqual(x, 47);
        }

        private void IncrementNumber(ref int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassedByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(ref book2);

            Assert.AreEqual("A GradeBook", book2.Name);
        }

        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Darien's GradeBook";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
