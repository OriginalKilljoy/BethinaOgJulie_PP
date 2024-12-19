using BethinaOgJulie_PP;

Console.WriteLine("Harry Potter Oppgave");

var character1 = new Character("Bethina SM", "Hufflepuff", 7, new List<string> { "1 x Health Potion", "A book - History of Magic" }, "Otter");
var character2 = new Character("Julie MV", "Ravenclaw", 7, new List<string> { "1 x Health Potion", "A small pouch of Gobstones" }, "Marsh Harrier");

List<string> objects = new List<string> { "boot", "pillow", "butterbeer", "quill", "really heavy book" };

Shop shop = new Shop();
Magic magic = new Magic();


Magic spell1 = new Magic("Wingardium Leviosa", "A feather floats gracefully in the air.");
Magic spell2 = new Magic("Accio", "A _ comes floating towards you!");
Magic spell3 = new Magic("Alohomora", "You unlock a treasure chest and find a _!");
Magic spell4 = new Magic("Expecto Patronum", "Your - comes shooting out of your wand and protects you from evil!");


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
            ChooseSpell(character);
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

string GetRandomObject()
{
    Random rand = new Random();
    int index = rand.Next(0, objects.Count);
    string randomItem = objects[index];
    return randomItem;
}

void ChooseSpell(Character character)
{
    Console.Clear();
    Console.WriteLine("Which spell do you want to cast?\n\nWingardium Leviosa\n\nAccio\n\nAlohamora\n\nExpecto Patronum\n\n[ 1 ] Go back");
    var userInput = Console.ReadLine().ToLower();
    switch (userInput)
    {
        case "wingardium leviosa":
            UseSpell(character, spell1);
            break;
        case "accio":
            
            UseSpell(character, spell2);
            break;
        case "alohamora":
            
            UseSpell(character, spell3);
            break;
        case "expecto patronum":
            UseSpell(character, spell4);
            break;
        case "1":
            StartMenu(character);
            break;
        default:
            Console.WriteLine("That is not a spell, check your spelling.");
            Thread.Sleep(2000);
            ChooseSpell(character);
            break;
    }
}

void UseSpell(Character character, Magic spell)
{
    Console.Clear();
    Console.WriteLine($"{spell.SpellName}!");
    Thread.Sleep(1500);
    Console.WriteLine($"{spell.DoMagic(GetRandomObject(), character)}");
    Thread.Sleep(2000);
    Console.Clear();
    StartMenu(character);
}