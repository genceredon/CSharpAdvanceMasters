using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03.Tuples
{

    public class TuplesUseCase
    {
        public TuplesUseCase()
        {
            // How to return condition valid and single data?
            ValidateEmail("email1@gmail.com");

            if (true)
            {
                Console.WriteLine("Email Matched!");
            }
            else
            {
                Console.WriteLine("No email found!!");
            }

            void ValidateEmail(string email)
            {
                if (email.Equals("email1@gmail.com"))
                {
                    //return "Email1User"
                }
                else
                {
                    //return false
                }
            }

            //(string username, bool valid) = ValidateEmail("email1@gmail.com");

            //if (valid)
            //{
            //    Console.WriteLine($"Hello {username}");
            //}
            //else
            //{
            //    Console.WriteLine("No email found!!");
            //}

            //(string username, bool isValid) ValidateEmail(string email)
            //{
            //    if (email.Equals("email1@gmail.com"))
            //    {
            //        return ("Email1User", true);
            //    }
            //    else
            //    {
            //        return (email, false);
            //    }
            //}


            // Conclusion
            /*
             * Tuples are a very concise way of representing data, and they can be very helpful when you want to return multiple values from a method. However, they can also make your code more difficult to read. If you're not careful, it's easy to create tuples that are difficult to understand.

               If the number of elements is over 3, it's better to use a class instead of a tuple. A class is more readable and it can be easier to add new members to a class than to a tuple.
             */
        }
    }
}