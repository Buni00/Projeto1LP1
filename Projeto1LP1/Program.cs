using System;
using System.Collections.Generic;

namespace Projeto1LP1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateBulbs();
        }


        /// <summary>
        /// Creates 3 bulbs and 3 buttons
        /// </summary>
        private static void CreateBulbs()
        {
            // Creates 3 bulbs
            Bulb bulb1 = new Bulb(1);
            Bulb bulb2 = new Bulb(2);
            Bulb bulb3 = new Bulb(3);

            // Create 3 buttons associated with different bulbs
            Button button1 = new Button(new List<Bulb>() { bulb1 } );
            Button button2 = new Button(new List<Bulb>() { bulb1, bulb2 });
            Button button3 = new Button(new List<Bulb>() { bulb2, bulb3 });
        }
    }
}
