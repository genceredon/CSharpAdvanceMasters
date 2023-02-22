using System;
using System.Collections.Generic;
using System.Text;

namespace Session_05.Generic
{
    public class InterfaceVsClasses
    {
        public void ShowDifferences()
        {
            List<string> tvShows = new List<string>();

            tvShows.Add("Starwars");
            tvShows.Add("Game of Thrones");
            tvShows.Add("Breaking Bad");
            tvShows.Add("Stranger Things");


            DisplayList(tvShows);
            GenericDisplayList(tvShows);
            GenericDisplayCollectionList(tvShows);
            GenericDisplayEnumerableList(tvShows);
        }

        private void DisplayList(List<string> tvShows)
        {
            foreach(var item in tvShows)
            {
                Console.WriteLine(item);
            }
            
        }

        private void GenericDisplayList(IList<string> tvShows)
        {
            tvShows.Insert(3, "SpyXFam");
            foreach (var item in tvShows)
            {
                Console.WriteLine(item);
            }

        }

        private void GenericDisplayCollectionList(ICollection<string> tvShows)
        {
            tvShows.Add("");
            foreach (var item in tvShows)
            {
                Console.WriteLine(item);
            }

        }
        private void GenericDisplayEnumerableList(IEnumerable<string> tvShows)
        {
            tvShows.GetEnumerator();
            foreach (var item in tvShows)
            {
                Console.WriteLine(item);
            }

        }
    }
}
