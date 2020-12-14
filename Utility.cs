using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace InClassAssignmentWeek7
{
    public static class Utility
    {
        public static string GetUserInput(string Title)
        {
            string userInput;
            WriteLine(Title);
            userInput = ReadLine();
            userInput = userInput.Trim();

            while (String.IsNullOrEmpty(userInput))
            {
                WriteLine("Please enter a value.");
                userInput = ReadLine();
                userInput = userInput.Trim();
            }
            return userInput;
        }
    }
}