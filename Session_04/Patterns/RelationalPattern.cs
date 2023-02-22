using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04.Patterns
{
    public class RelationalPattern
    {
        public RelationalPattern()
        {
            int grade = 90;
            string gradeEquivalent = GetGradeCategory(grade);
            Console.WriteLine($"The equivalent of grade {grade} is {gradeEquivalent}");
        }

        string GetGradeCategory(decimal grade) => grade switch
        {
            >= 95m => "A+",
            >= 90m => "B+",
            >= 85m => "C+",
            >= 80m => "D+",
            _ => "F"
        };

        string GetGradeCategoryBase(decimal grade) {
            return grade switch
            {
                > 95m => "A+",
                > 90m => "B+",
                > 85m => "C+",
                > 80m => "D+",
                _ => "F"
            };
        }

    }
}
