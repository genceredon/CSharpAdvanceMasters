using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04.Patterns
{
    public class CombinatorPattern
    {
        public CombinatorPattern()
        {
            char letter = 'a';
            int digit = 11;

            bool vowel = isVowel(letter);
            if (vowel)
            {
                Console.WriteLine($"Letter {letter} is a vowel");
            }
            else
            {
                Console.WriteLine("Not a vowel");
            }

            bool isValid = isBetween1And9(digit);
            if (isValid)
            {
                Console.WriteLine("It is a digit between 1 and 9");
            }
            else
            {
                Console.WriteLine("It is not between 1 and 9");
            }

            string gradeCategory = GetGradeCategory(100);
            Console.WriteLine(gradeCategory);
        }

        // Pattern Combinator
        bool isVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';
        bool isBetween1And9(int n) => n is >= 1 and <= 9;
        string GetGradeCategory(decimal grade) => grade switch
        {
            > 95m and <= 100 => "A+",
            > 90m and <= 95 => "A",
            > 85m and <= 90 => "B+",
            > 80m and <= 85 => "B",
            < 80 => "F",
            _ => throw new NotImplementedException()
        };

    }
}
