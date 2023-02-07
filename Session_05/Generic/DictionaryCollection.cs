using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class DictionaryCollection
    {
     
        public void CreateDictionary()
        {
            try
            {
                // Create new Dictionary
                Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

                //Add elements to dictionary
                // Let's create a daily event dictionary for The 1st week of January
                string[] events = { string.Empty, "New Year's Day", "Day 2", "Townhall Meeting", "Product Increment Planning", "Devs Meeting", "Weekend Rest", "Prep for Nextweek" };

                Console.WriteLine("Day " + string.Empty.PadRight(5) + " Event ");
                for (int i = 0; i <= 7; i++)
                {
                    keyValuePairs.Add(i, events[i]);
                }

                //TIP: You can update the value associated with a Key, Will change the "Day 2" event
                // Another TIP : before updating value, it's better to validate if the key is existing first -- with ContainsKey
                if (keyValuePairs.ContainsKey(2))
                {
                    keyValuePairs[2] = "Start work for the year";
                }


                // Retrieve all the Key and Value
                foreach (var kvp in keyValuePairs)
                {
                    Console.WriteLine(kvp.Key.ToString() + string.Empty.PadRight(5) + kvp.Value);
                }

                // Retrieve specific values with validation
                string specificVal = string.Empty;
                if (keyValuePairs.TryGetValue(2, out specificVal))
                {
                    Console.WriteLine(specificVal);
                }

                //Must throw exception if the Key is not valid
                Console.WriteLine(keyValuePairs[9]);

               // Remove a dictionary, pass value on another object
                if(keyValuePairs.Remove(2, out specificVal))
                {
                    Console.WriteLine(specificVal);
                }

                //Remove with just Key
                keyValuePairs.Remove(1);

            }
            catch(KeyNotFoundException q)
            {
                Console.WriteLine(q.Message);
            }

        }


    }
}
