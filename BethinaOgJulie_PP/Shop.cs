using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethinaOgJulie_PP
{
    internal class Shop
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to General Magic! We have everything you could ever need!\nWhat can I help you with today?");
            Console.WriteLine("[ 1 ] I would like to buy an animal!\n[ 2 ] I would like to a wand!");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    // Console.WriteLine("What animal would you like as a companion?");
                    // METODE FOR ANIMAL SELECTION
                    break;
                case "2":
                    // METODE FOR WAND SELECTION
                    break;
                default:
                    Console.WriteLine("Not a valid choice, try again");
                    break;
            }

        }
    }
}
