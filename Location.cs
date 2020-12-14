using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace InClassAssignmentWeek7
{
    public class Location
    {
        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public List<Item> Items
        {
            get; set;
        }

        public ConsoleColor LocationColor
        {
            get; set;
        }

        public List<Item> RequiredItems
        {
            get; set;
        }

        public Location() { }
        public Location(string name, string description, List<Item> items, List<Item> requiredItems, ConsoleColor color)
        {
            Name = name;
            Description = description;
            Items = items;
            RequiredItems = requiredItems;
            LocationColor = color;
        }


        public void PrintLocationInfo()
        {
            WriteLine($"You are at {Name}.  {Description}");
        }
    }
}