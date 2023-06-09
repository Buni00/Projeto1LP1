﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BulbsPuzzle
{
    class Program
    {   
        
        /// declaring 3 different buttons
        /// </summary>
        private static Button button1;
        private static Button button2;
        private static Button button3;

        /// <summary>
        /// declaring 3 different bulbs
        /// </summary>
        private static Bulb bulb1;
        private static Bulb bulb2;
        private static Bulb bulb3;
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;     //Worked before without it, just a precaution if used in another type of Console

            CreateBulbs();

            Instructions();

            GameCycle();

            
        }


        /// <summary>
        /// Creates 3 bulbs and 3 buttons
        /// </summary>
        private static void CreateBulbs()
        {
            // Creates 3 bulbs
            bulb1 = new Bulb(1);
            bulb2 = new Bulb(2);
            bulb3 = new Bulb(3);

            // Create 3 buttons associated with different bulbs
            button1 = new Button(new List<Bulb>() { bulb1 } );
            button2 = new Button(new List<Bulb>() { bulb1, bulb2 });
            button3 = new Button(new List<Bulb>() { bulb2, bulb3 });
        }

        

        /// <summary>
        /// Prints the game base Instructions
        /// </summary>
        private static void Instructions()
        {
            Console.WriteLine("Welcome to the Bulb Puzzle!\n" +
            "This game's goal is to light up all the bulbs using the buttons.\nEach button is assigned to 1 or more bulbs:\n"
            + "  Button 1 --> Bulb 1\n  Button 2 --> Bulb 1 & Bulb 2 \n  Button 3 --> Bulb 2 & Bulb 3\n"
            +"Use 1 - 3 keys to press the respective button.\n"
            + "The bulbs will start all turned off ->\u25EF\nBut be careful! You only have 6 moves!"
            );
        }
        
        /// <summary>
        /// Game loop that verifies win or loss condition and prints the state of the game every round
        /// </summary>
        private static void GameCycle()
        {
            int roundCounter = 6;
            int move;

            bool winGame = false;
            
            //if the requirements are not met goes to the game loop
            while (!winGame && roundCounter > 0)
            {   
                //shows the number of moves the user has left
                Console.WriteLine("\n\n==============" + $"\n{roundCounter} moves left");
                roundCounter -= 1;
                
                UpdateBulbState();
                
                Console.Write("User Input: ");         
                //waits for user's input
                move = Convert.ToInt32(Console.ReadLine());    
                
                
                switch(move)
                {
                    case 1:
                        button1.Press();
                        break;

                    case 2:
                        button2.Press();
                        break;

                    case 3:
                        button3.Press();
                        break;

                    default:
                        roundCounter += 1;                    //so the Counter doesn't go down when error occurs
                        Console.WriteLine("Error! The input must be a number between 1 and 3");
                        break;
                }
                
                //win condition
                if(bulb1.IsOn && bulb2.IsOn && bulb3.IsOn)
                {
                    Console.WriteLine();
                    UpdateBulbState();
                    winGame = true;

                }
                    
            }
            //if wins game prints this
            if (winGame == true)
                Console.WriteLine($"Wow! You have completed this challenge in {6-roundCounter} moves! \nYOU WIN");
            //if game loss prints this
            else
                Console.WriteLine("\nOh no... You exceeded the number of moves :/ \nGAME OVER");
            
        }
        
        /// <summary>
        /// Updates the state of the bulbs
        /// </summary>
        private static void UpdateBulbState()
        {
            // Print out the state of each bulb
            Console.WriteLine("Current bulb states:");
            Console.Write(bulb1+" ");
            Console.Write(bulb2+" ");
            Console.Write(bulb3+" \n\n");
        }
    }
}
