using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session_05.Generic
{
    public class ListCollection
    {
        public void CreateList()
        {
            // Create a new List of String
            List<string> ChannelName = new List<string>();

            //Insert Items to List
            ChannelName.Add("CNN");
            ChannelName.Add("Netflix");
            ChannelName.Add("HBO");                     

            if(!ChannelName.Contains("ABS"))
            {
                ChannelName.Add("ABS");
            }
         
            //Insert on specific index/order
            ChannelName.Insert(0, "GMA");

            Console.WriteLine("List of Channel Names");
            //Retrieve list of ChannelName
            foreach (var cn in ChannelName)
            {
                Console.WriteLine(cn);
            }

            // Retrieve/Update by Index is also possible
            ChannelName[2] = "LOL";
            Console.WriteLine("Updated Value : " + ChannelName[2]);
            //Remove
            ChannelName.Remove("ABS");
            //Remove By Index
            ChannelName.RemoveAt(2);

            Console.WriteLine("List of Channel Names");
            //Retrieve list of ChannelName
            foreach (var cn in ChannelName)
            {
                Console.WriteLine(cn);
            }

            // Create a list of Channel -- for another sample
            List<Channel> channels = new List<Channel>();
            channels.Add(new Channel { Id = 777, Name = "HBO", FrequencyNumber = 8457 });
            channels.Add(new Channel { Id = 555, Name = "Discovery Channel", FrequencyNumber = 78787 });
            channels.Add(new Channel { Id = 444, Name = "GMA", FrequencyNumber = 4577 });

            Console.WriteLine("List of Channel Names");
            //Retrieve list of Channels
            foreach (var cn in channels)
            {
                Console.WriteLine(cn);
            }

            //Bonus Sample : query the list
            var queryChannel = channels.Where(x => x.Id == 777);
            // Get Count of Channel queried
            Console.WriteLine("Query Count of Channel: " + queryChannel.Count().ToString());

            // Print Query Result
            Console.WriteLine("Channel Result");
            Console.WriteLine("Id" + string.Empty.PadRight(5) + " Channel Name");
            Console.WriteLine(queryChannel.FirstOrDefault().Id + string.Empty.PadRight(5) + queryChannel.FirstOrDefault().Name);


         
        }


    }

    public class Channel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FrequencyNumber { get; set; }
    }
}
