using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace RandomUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            // Username simulator :)

            Random random = new Random();
            string numbers = "0123456789";
            List<string> list1 = new List<string>() { "Banana", "Bear", "Moist", "Donkey", "Einstein", "Muffins", "AppleSauce", "Queenz", "Warm", "Buttz", "Twinning", "Dick", "Milk", "Wars", "Vodka"};
            List<string> list2 = new List<string>() { "Sunny", "Happy", "BestEver", "Cheers", "Funny", "SeriousSerious", "BOSS", "BestDad", "CutiePie", "NiceGuy"};
            List<string> list3 = new List<string>() { "UwU", "Stone", "King", "Pants", "Trees", "Grass", "Cursed", "Evil", "Villain", "Gigantus", "Chad", "Strippers", "Hatred", "Professional", "Jesus" };

            bool username = true;

            while (username)
            {
                Console.WriteLine("Welcome to the randomized username simulator!");
                Console.WriteLine("Are you looking for: 1) fun username, 2) serious username or 3) completely random?");
                Console.WriteLine("Enter a number from 1 to 3 please:");
                string usernamePreference = Console.ReadLine();

                if (usernamePreference == "1")
                {
                    int randomFun = random.Next(0, list1.Count);
                    string randomWord = list1[randomFun];
                    int randomFun2 = random.Next(0, list1.Count);
                    string randomWord2 = list1[randomFun2];

                    int numberFun = random.Next(0, numbers.Length);
                    char randomNumber = numbers[numberFun];

                    Console.WriteLine();
                    Console.WriteLine($"Random funny username generated: {randomWord}{randomWord2}{randomNumber}");
                    Console.WriteLine("Do you want to generate a new one (Y/N)?");
                    string reply2 = Console.ReadLine();
                    Console.WriteLine();

                    if (reply2 == "Y")
                    {
                        username = true;
                    }

                    else
                    {
                        username = false;
                        Console.WriteLine($"Bye Mr.{randomWord}{randomWord2}{randomNumber}!");
                        break;
                    }
                }

                else if (usernamePreference == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("What's your name?");
                    string name = Console.ReadLine();

                    int randomSerious = random.Next(0, list2.Count);
                    string randomS = list2[randomSerious];

                    Console.WriteLine();
                    Console.WriteLine($"Random serious username generated: {name}{randomS}");
                    Console.WriteLine("Do you want to generate a new one (Y/N)?");
                    string reply2 = Console.ReadLine();
                    Console.WriteLine();

                    if (reply2 == "Y")
                    {
                        username = true;
                    }

                    else
                    {
                        username = false;
                        Console.WriteLine($"Bye Mr.{name}{randomS}!");
                        break;
                    }
                }

                else if (usernamePreference == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("What's your favorite cheese?");
                    string cheese = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Name something you hate in this world?");
                    string hate = Console.ReadLine();

                    int randomRandom = random.Next(0, list3.Count);
                    string randomR = list3[randomRandom];

                    Console.WriteLine();
                    Console.WriteLine($"Random username generated: {hate}{randomR}{cheese}");
                    Console.WriteLine("Do you want to generate a new username (Y/N)?");
                    string reply2 = Console.ReadLine();
                    Console.WriteLine();

                    if (reply2 == "Y")
                    {
                        username = true;
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Bye Mr.{hate}{randomR}{cheese}!");
                        break;
                    }
                }
                
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Try again!");
                    username = true;
                }
            }
        }
    }
}