using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04.Patterns
{
    public class TuplePattern
    {
        public TuplePattern()
        {
            //Tuple and Relational pattern
            var projectGrade = GetGrade(Activity.Project, 75);
            Console.WriteLine(projectGrade);
        }

        string GetGrade(Activity activity, decimal grade) => (activity, grade) switch
        {
            (Activity.Project, > 90) => "A+",
            (Activity.Project, > 80) => "B+",
            (Activity.Project, > 70) => "C+",
            (Activity.Assignment, > 95) => "A+",
            (Activity.Assignment, > 90) => "A",
            (Activity.Assignment, > 85) => "B+",
            _ => "F"
        };

        string GetGradeBase(Activity activity, decimal grade)
        {
            return (activity, grade) switch
            {
                (Activity.Project, > 90) => "A+",
                (Activity.Project, > 80) => "B+",
                (Activity.Project, > 70) => "C+",
                (Activity.Assignment, > 95) => "A+",
                (Activity.Assignment, > 90) => "A",
                (Activity.Assignment, > 85) => "B+",
                _ => "F"
            };
        }
    }
    enum Activity
    {
        Assignment,
        Project
    }
}
