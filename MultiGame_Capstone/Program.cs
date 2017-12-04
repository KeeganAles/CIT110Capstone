﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiGame_Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static void NumberGuessing()
        {
            DisplayHeader("Welcome to the Number Guessing game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100...");

            Random rNum = new Random();
            int randNum = rNum.Next(1, 101);
            int i = 1;

            while (i < 101)
            {
                int userGuess;
                Console.WriteLine("What is your guess?");
                string userResponse = Console.ReadLine();
                while (!int.TryParse(userResponse, out userGuess))
                {
                    Console.WriteLine();
                    Console.WriteLine("It seems like you did not enter a number.");
                    Console.WriteLine("Please try again.");
                    Console.WriteLine();
                    Console.WriteLine("What is your guess?");
                    userResponse = Console.ReadLine();
                }

                if (userGuess == randNum)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Congratulations! You guessed the number! the number was {randNum}.");
                    Console.WriteLine($"It took you {i} attempts to guess the number!");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to go back to the main menu.");
                    Console.ReadLine();
                    break;
                }
                else if (userGuess < randNum)
                {
                    Console.WriteLine("Sorry, you need to guess higher!");
                    i = i + 1;
                }
                else if (userGuess > randNum)
                {
                    Console.WriteLine("Sorry, you need to guess lower!");
                    i = i + 1;
                }
                else
                {
                    Console.WriteLine("Start over!");
                }
            }
            
        }

        static void DisplayMenu()
        {
            string menuChoice;
            bool exiting = false;

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\tA) Play the Number Guessing game");
                Console.WriteLine("\tB) ");
                Console.WriteLine("\tC) ");
                Console.WriteLine("\tE) Exit");

                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        NumberGuessing();
                        break;

                    case "B":
                    case "b":
                        
                        break;

                    case "C":
                    case "c":
                        
                        break;

                    case "E":
                    case "e":
                        exiting = true;
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to the Multigame App.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tThanks for using the Multigame App.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }


    }
}