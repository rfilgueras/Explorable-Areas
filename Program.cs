using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Console;

namespace InClassAssignmentWeek7
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Empty Jetpack Joyride";

            Item CandyJetpack = new Item("Candy Jetpack", "It allows you to fly!  Unfortunately, fuel was not included.");
            Item ClimbingGear = new Item("Climbing Gear", "No fuel required.");
            Item Fuel = new Item("Hot Fudge", "Can be used as fuel.  Probably for a Jetpack but that's up to you.");
            Item CandyCrown = new Item("Candy Crown", "The ultimate head gear.  Gives you all of the Candy that exists (And sovereignty over Candy World).");
            Item AllTheCandy = new Item("All of the Candy", "Literally just all of it.");

            Location ClimbingStore = new Location("Climbing Store", "A store that serves all of your Candy Mountain climbing needs.", new List<Item> { ClimbingGear }, new List<Item> { }, ConsoleColor.Cyan);
            Location CandyMountain = new Location("Candy Mountain", "It's a mountain.  Of candy.", new List<Item> {CandyJetpack}, new List<Item> {ClimbingGear}, ConsoleColor.Magenta);
            Location House = new Location("Your House", "You live here!", new List<Item> {Fuel}, new List<Item> {}, ConsoleColor.DarkGreen);

            //create object without method!
            Location CottonCandyCloud = new Location()
            {
                Name = "Cotton Candy Cloud",
                Description = "A piece of Cotton Candy so large and light that it just became a cloud.",
                Items = new List<Item> { CandyCrown, AllTheCandy },
                RequiredItems = new List<Item> { CandyJetpack, Fuel },
                LocationColor = ConsoleColor.Yellow
            };

            List<Location> Locations = new List<Location>() {CandyMountain, ClimbingStore, CottonCandyCloud};

            Player Player1 = new Player();

            World world = new World("Candy World", Player1, House, Locations);

        }
    }
}
