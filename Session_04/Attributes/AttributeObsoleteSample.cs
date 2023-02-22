using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04.Attributes
{
    public class AttributeObsoleteSample
    {
        public AttributeObsoleteSample()
        {
            int num1 = 2;
            int num2 = 4;

            int sum = Add(num1, num2);

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        }

        [Obsolete("use Add(params int[] numbers)",false)]
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Add(params int[] numbers)
        {
            int Sum = 0;
            foreach (int num in numbers)
            {
                Sum += num;
            }
            return Sum;
        }
    }
}
