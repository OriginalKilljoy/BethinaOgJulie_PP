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

        //ctor
        public Character(string name, string house, int year, List<string>Inventory)
        {
            Name = name;
            House = house;
            Year = year;
            Inventory = new List<string>();
        }

        public void Introduction()
        {
            Console.WriteLine($"Hello! My name is {Name}, and I am in {House}. I am a {Year} year!\nI have these things in my inventory:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
