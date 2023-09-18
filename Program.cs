// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //bool to check if program is active or is going to exit
        bool isAlive = false;

        while (!isAlive)
        {
            //print options
            Console.WriteLine("This is the main menu. You can choose different options by entering the correct choice.");
            Console.WriteLine("0. Exit menu"); 
            Console.WriteLine("1. Youth or pensioner");
            Console.WriteLine("2. Calculate cinema price for a party");
            Console.WriteLine("3. Repeat a text 10 times without linebreaks");
            Console.WriteLine("4. The third word: prints the third word in the text");
            Console.Write("Enter your choice: ");

            string menuOption = Console.ReadLine();
            //switch case to perform various actions
            switch (menuOption)
            {
                case "0":
                    isAlive = true;
                    break;
                case "1":
                    CheckYouthOrPensioner();
                    break;
                case "2":
                    CalculatePartyPrice();
                    break;
                case "3":
                    RepeatText();
                    break;
                case "4":
                    PrintThirdWord();
                    break;
                
                default:
                    Console.WriteLine("Incorrect input. Enter a valid menu option (0-4).");
                    break;
            }
        }
    }
    //case1- youth or pensioner check
    public static void CheckYouthOrPensioner()
    {
        Console.Write("Enter age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age < 20)
            {
                Console.WriteLine("Youth Price: SEK 80");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensioner's price: SEK 90");
            }
            else
            {
                Console.WriteLine("Standard price: SEK 120");
            }
        }
        else
        {
            Console.WriteLine("Invalid Age.");
        }
    }

    public static void CalculatePartyPrice()
    {
        Console.Write("Enter the total number of people going for the cinema: ");
        //Read the total number of people in party and check if it is not less than or equal to 0
        if (int.TryParse(Console.ReadLine(), out int numberOfPeople) && numberOfPeople > 0)
        {
            int totalCost = 0;
           // iterate using for loop to read age of all people
            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.Write($"Enter Age of person{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int personAge))
                {
                    if (personAge < 20)
                    {
                        totalCost += 80;
                    }
                    else if (personAge > 64)
                    {
                        totalCost += 90;
                    }
                    else
                    {
                        totalCost += 120;
                    }
                }
                else
                {
                    // Decrement i to re-enter the age for the current person.
                    Console.WriteLine("Wrong age. Enter a valid age.");
                    i--; 
                }
            }

            Console.WriteLine($"Number of people: {numberOfPeople}");
            Console.WriteLine($"Total cost for the entire party: SEK {totalCost}");
        }
        else
        {
            Console.WriteLine("Enter a valid number.");
        }
    }
    //function to print text 10 times
    public static void RepeatText()
    {
        //read and save text into a variable
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        //for loop to print text 10 times without linebreaks
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}.{text} ");
        }
        Console.WriteLine();
    }

    public static void PrintThirdWord()
    {
        Console.Write("Enter a sentence with at least 3 words: ");
        var input = Console.ReadLine();

        string[] words = input.Split(' ');

        if (words.Length >= 3)
        {
            string thirdWord = words[2];
            Console.WriteLine($"Third word is : {thirdWord}");
        }
        else
        {
            Console.WriteLine("Enter a sentence with at least 3 words.");
        }
    }
}
