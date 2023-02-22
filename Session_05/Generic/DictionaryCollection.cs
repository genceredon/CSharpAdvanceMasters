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
                Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

                // Add Element to dictionary
                keyValuePairs.Add(2, "New year");
                keyValuePairs.Add(3, "Townhall meeting");
                keyValuePairs.Add(1, "Weekend");


                // Retrieve all data added on dictionary
                foreach (var kvp in keyValuePairs)
                {
                    Console.WriteLine(kvp.Key.ToString() + " - " + kvp.Value);
                }

                // Retrive the dictionary value by key in bracket
                Console.WriteLine(keyValuePairs[2]);
                Console.WriteLine(keyValuePairs[1]);
                Console.WriteLine(keyValuePairs[3]);

                // And you can also retrieve value by method TryGetValue passing key, and out for passing the value if the key is true/existing
                string value = string.Empty;
                if (keyValuePairs.TryGetValue(2, out value))
                {
                    Console.WriteLine("TryGetValue : " + value);
                }

                // But how can we get the key by Value
                var getKeyByvalue = keyValuePairs.FirstOrDefault(ev => ev.Value == "Weekend").Key;
                Console.WriteLine(getKeyByvalue);

                // Update element 
                // TIP: Update value with validation that the key is existing with ContainsKey
                if (keyValuePairs.ContainsKey(2))
                {
                    keyValuePairs[2] = "Start of the year";
                }


                // Remove an element by key
                keyValuePairs.Remove(2);

                // Another sample on how to remove an element by key 
                if (keyValuePairs.Remove(2, out value))
                {
                    Console.WriteLine("Removed value : " + value);
                }

                foreach (var kvp in keyValuePairs)
                {
                    Console.WriteLine(kvp.Key.ToString() + " - " + kvp.Value);
                }

            }
            catch (KeyNotFoundException q)
            {
                Console.WriteLine(q.Message);
            }

        }


    }
}
