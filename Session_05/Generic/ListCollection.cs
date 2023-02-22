using System;
using System.Collections.Generic;
using System.Linq;

namespace Session_05.Generic
{
    public class ListCollection
    {
        public void CreateList()
        {

            List<Channel> channels = new List<Channel>();

            ////Add Items
            channels.Add(new Channel { Id = 777, Name = "HBO", FrequencyNumber = 7799 });
            channels.Add(new Channel { Id = 777, Name = "HBO", FrequencyNumber = 7799 });
            channels.Add(new Channel { Id = 777, Name = "Discovery Channel", FrequencyNumber = 78787 });
            channels.Add(new Channel { Id = 444, Name = "GMA", FrequencyNumber = 4577 });
            channels.Add(new Channel { Id = 34, Name = "ABC", FrequencyNumber = 4577 });

            Console.WriteLine("List of Channel Names");

            // Update Item
            channels[3] = new Channel { Id = 5454, Name = "LOL" };

            List<Channel> channels1 = new List<Channel> {
                new Channel{ Id = 74949, Name = "Prime", FrequencyNumber = 4234}
            };

            //Merge Channel list to another list
            channels.AddRange(channels1);

            foreach (var cn in channels)
            {
                Console.WriteLine("Id: " + cn.Id + " - Channel Name : " + cn.Name);
            }

        }



    }

    public class Channel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FrequencyNumber { get; set; }
    }
}
