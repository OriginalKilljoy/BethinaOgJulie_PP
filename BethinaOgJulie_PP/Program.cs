using BethinaOgJulie_PP;

Console.WriteLine("Harry Potter Oppgave");

var character1 = new Character("Bethina SM", "Hufflepuff", 7, new List<string> { "1 x Health Potion", "A book - History of Magic" }, "Otter");
var character2 = new Character("Julie MV", "Ravenclaw", 7, new List<string> { "1 x Health Potion", "A small pouch of Gobstones" }, "Marsh Harrier");

Shop shop = new Shop();

ChooseCharacter();

void ChooseCharacter()
{
    Console.WriteLine("Who's playing?");
    Console.WriteLine($"[ 1 ] {character1.Name}\n[ 2 ] {character2.Name}\n");
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
            Console.WriteLine("Sorry you need to choose a charcter to continue, try again!\n\n");
            ChooseCharacter();  
            break;
    }
}

void Run(Character character)
{
    Console.Clear();
    character.Introduction();
    StartMenu(character);

    
}

void StartMenu(Character character)
{
    Thread.Sleep(2000);
    Console.WriteLine("What would you like to do today?\n[ 1 ] I would like to the shop and buy some things.\n[ 2 ] I would like to do some magic!\n[ 3 ] I would like to exit this program now, thank you.");
    var userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "1":
            shop.Menu(character);
            break;
        case "2":
            // DO SOME MAGIC
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("The program will now shut down, farewell for now young witch!");
            Thread.Sleep(1500);
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Not a valid choice, try again!");
            StartMenu(character);
            break;


    }
}
