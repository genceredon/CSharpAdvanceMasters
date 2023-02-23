using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.LINQ_Queries
{
    public class SimpleLinqQuery
    {
        public void DisplayScores()
        {
            // The Three Parts of a LINQ Query:
            // 1. Specify the data source.
            int[] scores = { 97, 92, 81, 60 };

            // 2. Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // 3. Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            // Output: 97 92 81
        }
    }
}
