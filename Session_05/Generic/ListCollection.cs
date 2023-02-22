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
            List<string> ChannelNames = new List<string>();

            // Add items to List
            ChannelNames.Add("CNN");
            ChannelNames.Add("Netflix");
            ChannelNames.Add("HBO");

            Console.WriteLine("List of Channel Names");

            foreach (var cn in ChannelNames)
            {
                Console.WriteLine(cn);
            }

            // Retrieve single element
            Console.WriteLine(ChannelNames[2]);

            // Update element by index
            ChannelNames[1] = "Disney Plus";

            Console.WriteLine("Updated : " + ChannelNames[1]);


            // Remove from list
            ChannelNames.Remove("CNN");
            // Remove by Index
            ChannelNames.RemoveAt(1);


            List<Channel> channels = new List<Channel>();

            ////Add Items
            channels.Add(new Channel { Id = 777, Name = "HBO", FrequencyNumber = 7799 });
            channels.Add(new Channel { Id = 555, Name = "Discovery Channel", FrequencyNumber = 78787 });
            channels.Add(new Channel { Id = 444, Name = "GMA", FrequencyNumber = 4577 });
            channels.Add(new Channel { Id = 34, Name = "ABC", FrequencyNumber = 4577 });
            channels.Add(new Channel { Id = 232, Name = "GMA1", FrequencyNumber = 4577 });

            Console.WriteLine("List of Channel Names");


            // Update Item
            channels[2] = new Channel {Id = 5454, Name = "LOL" };


            // Remove
            var channelToRemove = channels.FirstOrDefault(cn => cn.Name == "HBO");
            //Remove Item
            channels.Remove(channels[2]);
            //channels.RemoveAt(2);

            List<Channel> channel1 = new List<Channel> {
                new Channel { Id = 832748 , Name = "Prime", FrequencyNumber = 4784}
            };

            // Sort by Name
            channels = channels.OrderBy(cn => cn.Name).ToList();

            // Merge list to another list
            channels.AddRange(channel1);


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
