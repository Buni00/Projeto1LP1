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

        private static void UpdateBulbState()
        {
            // Print out the state of each bulb
            Console.WriteLine("Current bulb states:");
            Console.WriteLine(bulb1);
            Console.WriteLine(bulb2);
            Console.WriteLine(bulb3);
        }
    }
}
