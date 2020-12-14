using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace InClassAssignmentWeek7
{
    public class Item
    {

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }
    }
}