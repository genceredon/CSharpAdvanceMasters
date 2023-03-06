using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Session_06.Non_Generic
{
    public class HashTableCollection
    {
        public void CreateHashTable()
        {
            Hashtable dictionaryHash = new Hashtable();

            // duplicate keys, but some of the values are duplicates.
            dictionaryHash.Add(1, true);
            dictionaryHash.Add("movie", "Avengers");
            dictionaryHash.Add(true, 777);
            dictionaryHash.Add("character", null);

            // Update by Key
            dictionaryHash["character"] = 454.05;

            // Without Key
            if (!dictionaryHash.ContainsKey(false))
            {
                dictionaryHash.Add(false, "falls");
            }

            foreach (DictionaryEntry de in dictionaryHash)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }

            ICollection keys = dictionaryHash.Keys;

            Console.WriteLine("Keys in HashTable");
            foreach (dynamic key in keys)
            {
                Console.WriteLine(key);
            }

        }
    }
}
