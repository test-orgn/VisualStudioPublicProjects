using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public float avgGrade;
        public float highestGrade;
        public float lowestGrade;

        public GradeStatistics()
        {
            highestGrade = 0;
            lowestGrade = float.MaxValue;
        }
    }
}
