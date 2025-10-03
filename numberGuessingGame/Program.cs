//set playAgain to "Y" 
Random rand = new Random();
string playAgain = "Y";

//While loop which loops if playAgain is Y
while (playAgain.ToUpper() == "Y")
{
    //Ask user for difficulty
    Console.WriteLine("Welcome to the super fun number guessing game!!!");
    Console.WriteLine("Select difficulty level: ");
    Console.WriteLine("1 = Easy (1-10)");
    Console.WriteLine("2 = Medium (1-50)");
    Console.WriteLine("3 = Hard (1-100)");
    Console.Write("Enter selection >> ");

    int maxRange = 10;
    string choice = Console.ReadLine();

    //Set the difficulty
    switch (choice)
    {
        case "1":
            maxRange = 10;
            break;
        case "2":
            maxRange = 50;
            break;
        case "3":
            maxRange = 100;
            break;
        default:
            Console.WriteLine("Invalid choice, defaulting to easy mode.");
            maxRange = 10;
            break;
    }
    //Generate a random number based off difficulty
    //Set numberGuesses = 0
    int numbertoGuess = rand.Next(1, maxRange + 1);
    int guess = 0;
    int numberGuesses = 0;

    Console.WriteLine($"Choose a number between 1 and {maxRange}");

    do
    {
        //Ask user for a number between 1 and the difficulty range = numbertoGuess
        Console.Write("enter your guess>> ");
        string guessInput = Console.ReadLine();

        if (int.TryParse(guessInput, out guess))
        {
            numberGuesses++;

            if (guess < numbertoGuess)
            {
                //If guess is too low
                //Writeline "Guess is too low, try again!"
                Console.WriteLine("Too low, try again!");
            }
            else if (guess > numbertoGuess)
            {
                //Else if guess is too high
                //Writeline "Guess is too high, try again!"
                Console.WriteLine("Too high, try again!");
            }
            else
            {
                //Else if Guess = numbertoGuess
                //Writeline "Congratulations! You were correct!"
                //Display total number of numberGuesses
                Console.WriteLine($"Congratulations! You got it right! You guessed it in {numberGuesses} tries!");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number!");
        }
    } while (guess != numbertoGuess);

    //WriteLine "Would you like to play again? Y/N"
    Console.Write("Would you like to play again? (Y/N)>> ");
    playAgain = Console.ReadLine();
}