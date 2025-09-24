// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("1) english");
Console.WriteLine("2) spanish");
Console.WriteLine("3) ebonics");
//blank space for "spacing"
Console.WriteLine();

// Takes in a llangauge choice
Console.Writeline(">> ");
string choice = Console.ReadLine();

Console.WriteLine();

Console.Write("Enter your name: ");
string name = Console.ReadLine();

//empty string called greeting
string greeting;

// starts a swtich with chpoce as the cases
switch (choice)
{
    case "english":
        greeting = $"Hello, {name}!";
        //prevents the swtich from falling through
        break;
    case "spanish":
        greeting = $"Hola, {name}";
        break;
    case "ebonics":
        greeting = $"Wuz good, {name}";
        break;
    default:
        greeting = $"Invalid input, {name}";
        break;
}

Console.WriteLine();

Console.WriteLine(greeting);