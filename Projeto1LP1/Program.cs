using System;
using System.Collections.Generic;

namespace Projeto1LP1
{
    class Program
    {
        private static Button button1;
        private static Button button2;
        private static Button button3;

        private static Bulb bulb1;
        private static Bulb bulb2;
        private static Bulb bulb3;
        
        static void Main(string[] args)
        {
            CreateBulbs();

            Intructions();

            button1.Press();

            UpdateBulbState();

            
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
        /// Updates the state of the bulbs
        /// </summary>
        private static void UpdateBulbState()
        {
            // Print out the state of each bulb
            Console.WriteLine("Current bulb states:");
            Console.Write(bulb1+" ");
            Console.Write(bulb2+" ");
            Console.Write(bulb3+" ");
        }

        private static void Intructions()
        {
            Console.WriteLine("Welcome to the Bulb Puzzle!\n" +
            "This game's goal is to light up all the bulbs using the buttons.\nEach button is assigned to 1 or more bulbs:\n"
            + "  Button 1 --> Bulb 1\n  Button 2 --> Bulb 1 & Bulb 2 \n  Button 3 --> Bulb 2 & Bulb 3\n"
            +"Use 1 - 3 keys to press the respective button.\n"
            + "The bulbs will start all turned off ->\u25EF\nBut be careful! You only have 6 moves!");
        }
    }
}
