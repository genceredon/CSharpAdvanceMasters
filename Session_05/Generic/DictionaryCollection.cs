
using System;
using System.Collections.Generic;
using System.Linq;

namespace Session_05
{
    public class DictionaryCollection
    {
        public void CreateDictionary()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            // Add Element to dictionary
            keyValuePairs.Add(2, "New year");
            keyValuePairs.Add(3, "Townhall meeting");
            keyValuePairs.Add(1, "Weekend");

            // Remove an element by key
            //keyValuePairs.Remove(2);

            // with Validation
            string value = string.Empty;
            if(keyValuePairs.Remove(2, out value))
            {
                Console.WriteLine("Removed value : " + value);
            }

            foreach (var kvp in keyValuePairs)
            {
                Console.WriteLine(kvp.Key.ToString() + " - " + kvp.Value);
            }


        }
    }
}
