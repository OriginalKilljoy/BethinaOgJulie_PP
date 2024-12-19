using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethinaOgJulie_PP
{
    internal class Character
    {
        public string Name;
        public string House;
        public int Year;
        public List<string> Inventory;
        public string Companion;
        public string Patronus;

        //ctor
        public Character(string name, string house, int year, List<string>inventory, string patronus)
        {
            Name = name;
            House = house;
            Year = year;
            Inventory = inventory;
            Patronus = patronus;
        }

        public void Introduction()
        {
            Console.Clear();
            Console.WriteLine($"Hello! My name is {Name}, and I am in {House}. I am a {Year} year!\nI have these things in my inventory:");
            PrintInventory();
            Console.WriteLine();
        }

        public void PrintInventory()
        {
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
