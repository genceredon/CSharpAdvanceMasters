using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.LINQ_Queries
{
    public class LINQToObjects
    {
        public void LINQToObjectsSample()
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };

            double average = nums.Take(6).Average();

            var above = from n in nums 
                        where n > average 
                        select n;
        }
    }
}
