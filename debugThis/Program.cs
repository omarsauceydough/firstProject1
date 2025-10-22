// Debug This! 
// Your job: find and fix the bugs and add defensive programming

// Even though we are writing top-level code, we still need two "using" statements; enter them below

using System.ComponentModel;

Console.WriteLine("Welcome to the Debugging Challenge!"); //Added missing period between Console and WriteLine
Console.Write("Enter your name>> "); // Changed ? to >>
string name = Console.ReadLine();

//adding check for null or empty name
if (string.IsNullOrEmpty(name))
{
    name = "Anonymous";
}

Console.WriteLine($"Greetings {name}! Let's crunch some numbers."); // Rewrote this line
Console.Write("Enter a number: ");
string numberInput = Console.ReadLine();
int number;
if(!int.TryParse(numberInput, out number))
{
    Console.WriteLine("Invalid number input! Using 5 instead!");
    number = 5;
}
if (number == 0) //Added divde by 0 check 
{
    Console.WriteLine("Cannot divide by 0! Using 1 instead!");
    number = 1;
}

int result = 100 / number; // Check this line
Console.WriteLine($"100 divided by {number} is: {result}"); // Rewrote this line

int remainder = 100 % number; // Changed / to %
Console.WriteLine($"{remainder} Is the remainder of 100 divided by your number!"); // Rewrote this line

if (number == 10) // Fixed ( = -> == )
{
    Console.WriteLine("You entered ten!");
}
else //Fixed ( els -> else)
{
    Console.WriteLine("You did NOT enter ten."); //Changed didn't to did NOT to get rid of the yellow box
}

int counter = 0;
while (counter <= number)
{
    Console.WriteLine($"Counting up: {counter}"); //Rewrote this line
    counter++; //Changed -- to ++
}
Console.WriteLine("Done counting!");

string again = "yes"; //added = "yes"
while(again == "yes") //Added again == yes
{
    Console.WriteLine("Do you want to see your number squared? (yes/no)");
    again = Console.ReadLine();

    if (again == "yes")
    {
        Console.WriteLine($"Your number squared is: {number * number}"); //Rewrote this line
        break; //Added break
    }
    else
    {
        Console.WriteLine("Moving on then!");
        break; //Added else statement
    }
}
//Removed do while line for a for loop instead
for (int i = 5; i >= 0; i--)
{
    Console.WriteLine($"Countdown: {i}");
}

int[] scores = new int[5];
scores[4] = 100; //Changed 5 to 4
Console.WriteLine($"First score: {scores[0]}"); //Rewrote this line
Console.WriteLine($"Last score: {scores[4]}"); //Completed line

List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };
fruits.Remove("Apple"); //Removed apple instead because pineapple wasnt on the List
fruits.Add("Orange"); //Changed null to orange?

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit.ToUpper()); //Found nothing wrong
}

Console.Write("Pick a number between 1 and 3: ");
string choiceInput = Console.ReadLine(); //using TryParse for choice input
int choice;
if(!int.TryParse(choiceInput, out choice))
{
    Console.WriteLine("Invalid choice, choosing 1 instead!");
}

switch (choice) //added breaks to fix error, fixed spelling error (choce -> choice)
{
    case 1:
        Console.WriteLine("You picked one!");
        break;
    case 2:
        Console.WriteLine("You picked two!");
        break;
    case 3:
        Console.WriteLine("You picked three!");
        break;
    default:
        Console.WriteLine("That’s not between 1 and 3!");
        break;
}

Console.WriteLine($"Thanks for debugging, {name}!");
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();
