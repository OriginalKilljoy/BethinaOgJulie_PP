using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethinaOgJulie_PP
{
    internal class Shop
    {
        public void Menu(Character character)
        {
            Console.WriteLine("Welcome to General Magic! We have everything you could ever need!\nWhat can I help you with today?");
            Console.WriteLine("[ 1 ] I would like to buy an animal!\n[ 2 ] I would like to a wand!\n[ 3 ] Exit shop");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    BuyAnimals(character);
                    break;
                case "2":
                    BuyWands(character);
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Not a valid choice, try again");
                    break;
            }

        }

        public void BuyAnimals(Character character)
        {
            Console.WriteLine("What animal would you like as a companion?\n[ 1 ] Cat\n[ 2 ] Toad\n[ 3 ] Owl\n[ 4 ] Rat");
            var userInput = Console.ReadLine();
            switch (userInput) 
            {
                case "1":
                    character.Inventory.Add("Cat");
                    Console.WriteLine("Congratulations with your new companion! You bought a cat, treat them well!");
                    break;
                case "2":
                    character.Inventory.Add("Toad");
                    Console.WriteLine("Congratulations with your new companion! You bought a toad, treat them well!");
                    break;
                case "3":
                    character.Inventory.Add("Owl");
                    Console.WriteLine("Congratulations with your new companion! You bought an owl, treat them well!");
                    break;
                case "4":
                    character.Inventory.Add("Rat");
                    Console.WriteLine("Congratulations with your new companion! You bought a rat, treat them well!");
                    break;
                default:
                    Console.WriteLine("You didn't choose an animal, try again!");
                    break;
            }
        }

        public void BuyWands(Character character)
        {
            Console.WriteLine("Which wand chooses you I wonder..");
            Console.WriteLine("[ 1 ] Holly wood wand with a Phoenix feather core\n[ 2 ] Hawthorn wood wand with Unicorn hair core\n[ 3 ] Vine wood wand with a Dragon heartstring core\n[ 4 ] Yew wood wand with a Dragon heartstring core");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    character.Inventory.Add("Holly wood wand with a Phoenix feather core");
                    Console.WriteLine("Ah, I see the Holly wood and Phoenix feather cought your eye! Marvelous, it seems it chose you as well, congratulations!");
                    break;
                case "2":
                    character.Inventory.Add("Hawthorn wood wand with Unicorn hair core");
                    Console.WriteLine("Ah, I see the Hawthorn wood and Unicorn hair cought your eye! Marvelous, it seems it chose you as well, congratulations!");
                    break;
                case "3":
                    character.Inventory.Add("Vine wood wand with a Dragon heartstring core");
                    Console.WriteLine("Ah, I see the Vine wood and Dragon heartstring cought your eye! Marvelous, it seems it chose you as well, congratulations!");
                    break;
                case "4":
                    character.Inventory.Add("Yew wood wand with a Dragon heartstring core");
                    Console.WriteLine("Ah, I see the Yew wood and Dragon heartstring cought your eye! Marvelous, it seems it chose you as well, congratulations!");
                    break;
                default:
                    Console.WriteLine("That's not a wand, try again!");
                    break;
            }
        }
    }
}
