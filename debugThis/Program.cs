// Debug This! 
// Your job: find and fix the bugs and add defensive programming

// Even though we are writing top-level code, we still need two "using" statements; enter them below

Console.WriteLine("Welcome to the Debugging Challenge!"); //Added missing period between Console and WriteLine
Console.Write("Enter your name? "); // Check this line
string name = Console.ReadLine();

Console.WriteLine($"Hello " + name + "! Let's do some math."); // Rewrite this line
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()); // Check this line

int result = 100 / number; // Check this line
Console.WriteLine("100 divided by your number is: " + result); // Rewrite this line

int remainder = 100 / number; // Check this line
Console.WriteLine("The remainder of 100 divided by your number is: " + remainder); // Rewrite this line

if (number == 10) // Fixed ( = -> == )
{
    Console.WriteLine("You entered ten!");
}
else //Fixed ( els -> else)
{
    Console.WriteLine("You did NOT enter ten."); //Changed didn't to did NOT to get rid of the yellow box
}

int counter = 0;
while (counter < number)
{
    Console.WriteLine("Counting up: " + counter); // Rewrite this line
    counter--; // Check this line
}
Console.WriteLine("Done counting!");

string again;
while()
{
    Console.WriteLine("Do you want to see your number squared? (yes/no)");
    again = Console.ReadLine();

    Console.WriteLine("Your number squared is: " + number * number); // Rewrite this line. Hint: Use format strings to make this line better
}
do (again == "yes"); // There are two fixes to make to this line


while (int i = 5; i >= 0; i++) // Changed to while loop,
{
    Console.WriteLine("Countdown: " + i);
}

int[] scores = new int[5];
scores[5] = 100; // Check this line
Console.WriteLine("First score: " + scores[0]); // Check this line and rewrite it
Console.WriteLine("Last score: "); // Finish this line

List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };
fruits.Remove("Pineapple"); // Check this line
fruits.Add(null); // Check this line

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit.ToUpper()); // Check this line
}

Console.Write("Pick a number between 1 and 3: ");
int choice = int.Parse(Console.ReadLine());

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












































































Console.WriteLine("Thanks for debugging, " + name + "!");
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();
