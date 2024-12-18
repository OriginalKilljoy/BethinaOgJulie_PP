using BethinaOgJulie_PP;

Console.WriteLine("Harry Potter Oppgave");

var character1 = new Character("Bethina SM", "Hufflepuff", 7, new List<string> { "1 x Health Potion", "A book - History of Magic" });
var character2 = new Character("Julie MV", "Ravenclaw", 7, new List<string> { "1 x Health Potion", "A small pouch of Gobstones" });

Shop shop = new Shop();

ChooseCharacter();

void ChooseCharacter()
{
    Console.WriteLine("Who's playing?");
    Console.WriteLine($"[ 1 ] {character1.Name}\n[ 2 ] {character2.Name}");
    var userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Run(character1);
            break;
        case "2":
            Run(character2);
            break;
        default:
            Console.WriteLine("Sorry you need to choose a charcter to continue, try again!");
            break;
    }
}

void Run(Character character)
{
    character1.Introduction();
    shop.Menu(character1);
}