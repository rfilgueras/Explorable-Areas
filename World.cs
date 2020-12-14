using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Console;

namespace InClassAssignmentWeek7
{
    public class World
    {
        public List<Location> Locations {get; set;}

        public string Name
        {
            get; set;
        }

        public Player CurrentPlayer
        {
            get; set;
        }

        public World(string name, Player player, Location defaultLocation, List<Location> locations)
        {
            Name = name;
            CurrentPlayer = player;
            CurrentPlayer.CurrentLocation = defaultLocation;
            Locations = locations;
            SetUpPlayer();
        }

        public void SetUpPlayer()
        {
            WriteLine($"Welcome to {Name}!");
            CurrentPlayer.Name = Utility.GetUserInput("What is your name?");
            WriteLine($"Your current location is {CurrentPlayer.CurrentLocation.Name}.");
            DisplayLocationItems();
        }

        public void ChangeLocation()
        {
            int index = 1;
            foreach (var Location in Locations)
            {
                WriteLine($"{index}: {Location.Name} \n{Location.Description}");
            }

            int userChoice = 0;
            string userInput = Utility.GetUserInput("Where would you like to go?");
            int.TryParse(userInput, out userChoice);
            if (userChoice > 0 && userChoice <= Locations.Count)
            {
                userChoice--;
                Location newLocation = Locations[userChoice];
                //this checks whether or not the player is in possesion of the required item, we start with true because there are some instances where a location has no required items.
                bool HasRequiredItems = true;

                //the loop checks to see if the items are NOT in the inventory.  the loop breaks when ONE item is not present.
                foreach (var Item in newLocation.RequiredItems)
                {
                    if (!CurrentPlayer.Inventory.Contains(Item))
                    {
                        HasRequiredItems = false;
                        break;
                    }
                }

                if (HasRequiredItems)
                {
                    CurrentPlayer.CurrentLocation = newLocation;
                    DisplayLocationItems();
                }
                else
                {
                    WriteLine("Uh oh.  You're missing something!");
                    ChangeLocation();
                }

            }

        }

        public void DisplayLocationItems()
        {
            int index = 1;
            WriteLine($"There are some items laying around.");

            foreach (var Item in CurrentPlayer.CurrentLocation.Items)
            {
                WriteLine($"{index}: {Item.Name} \n{Item.Description}");
            }

            int userChoice = 0;
            string userInput = Utility.GetUserInput("Which item would you like to pick up?");
            int.TryParse(userInput, out userChoice);
            if (userChoice > 0 && userChoice <= CurrentPlayer.CurrentLocation.Items.Count)
            {
                userChoice--;
                Item PickedUpItem = CurrentPlayer.CurrentLocation.Items[userChoice];
                CurrentPlayer.CollectItem(PickedUpItem);
            }

        }
    }
}