using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.ExtensionMethods
{
    public static class Helper
    {
        public static int WordCount(this string str)
        {
            var count = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }

        public static bool IsIntegerLessThanZero(this int num)
        {
            return num < 0;
        }
    }
}
