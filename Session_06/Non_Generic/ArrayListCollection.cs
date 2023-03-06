
using System;
using System.Collections;
using System.Collections.Generic;


namespace Session_06.Non_Generic
{
    public class ArrayListCollection
    {
        public void CreateArrayList()
        {
            ArrayList favorites = new ArrayList();

            // Add to ArrayList
            favorites.Add(7);
            favorites.Add(" ");
            favorites.Add("Chewiee");
            favorites.Add(null);
            favorites.Add(true);
            favorites.Add(8.0888);
            favorites.Add(7);

            // You can also add a list
            List<string> books = new List<string>
            {
                { "Harry Potter" }, {"Superhuman"}
            };

            List<int> numbers = new List<int>
            {
                { 1 }, {5}, {3}
            };

            favorites.Add(books);
            favorites.AddRange(numbers);

            Console.WriteLine("\n\nOriginal Array List");
          
            //Update ArrayList
            favorites[2] = false;

            //Console.WriteLine();
            //Console.WriteLine("Updated Value : " + favorites[2]?.ToString());

            // Remove from ArrayList
            favorites.RemoveAt(2);
            favorites.Remove(null);

            //Get the index first 7
            var firstIndex = favorites.IndexOf(7);
            var lastIndex = favorites.LastIndexOf(7);

            //Removing by range (starting index to end index)
            favorites.RemoveRange(firstIndex, lastIndex);

            // New ArrayList
            ArrayList newArray = new ArrayList { { "Time" }, { "is" }, { "Gold" } };

            // Sort ArrayList
            newArray.Reverse();

          

            // Clone ArrayList
            ArrayList cloneList = (ArrayList)favorites.Clone();
            favorites.Add(false);

            foreach (var items in favorites)
            {
                Console.WriteLine(items);
            }

            // Insert to a specific Index
            cloneList.Insert(1, "Hello");

            Console.WriteLine();
            Console.WriteLine("Clone List");
            foreach (var clone in cloneList)
            {
                var type = clone?.GetType();

                Console.WriteLine(clone);
            }

            

            //foreach (var items in favorites)
            //{
            //    Console.WriteLine(items);
            //}


        }
    }
}
