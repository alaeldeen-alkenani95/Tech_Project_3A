/*
Name: Alaeldeen Alkenani
Date: 9/24/2020
Section: Creating Custom Methods
Description: This program demonstrates the use of custom method w
             which allows the user to enter his or her name.
*/

using System;

namespace Tech_Project_3A
{
    class Program
    {
        private static void Main(string[] args)
        {

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Hello, what is your name?");

                // Get the user's name
                string name = Console.ReadLine();

                // Print the name using a method
                MyName(name);

                // Ask the user if he or she want to run the program again
                Console.WriteLine("Would you like to run the program again? Type 'Y' key if so.");

                // Exit the program if the 'Y' key was not selected
                var key = Console.ReadKey();
                if (!(key.KeyChar == 'y' || key.KeyChar == 'y'))
                {
                    exit = true;
                }
                else
                {
                    // Add in an empty line at the start of the next loop.
                    Console.WriteLine();
                }
            }
        }

        private static void MyName(string name)
        {
            string output = name;

            // Custom message for output based on the entered name
            switch (name.ToLower())
            {
                case "Tom Brady":
                    output += " - Go Bucs!";
                    break;
                case "Alaeldeen Alkenani":
                    output += " - The Tampa Bay Buccaneers are my favorite NFL footbal teams";
                    break;
                default:
                    output += "!";
                    break;
            }

            Console.WriteLine("Hello " + output);
        } // end of main
    } // end of class
} // end of program

