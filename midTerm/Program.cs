internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello initial commit!");

        //initialize arrays and variables and whatnot
        string[] historyWords = { "WASHINGTON", "LINCOLN", "REVOLUTION", "CONSTITUTION", "INDEPENDENCE", "GOVERNMENT", "DEMOCRACY", "PRESIDENT", "FREEDOM", "AMENDMENT" };

        string[] animalWords = { "ELEPHANT", "GIRAFFE", "KANGAROO", "DOLPHIN", "BUTTERFLY", "CROCODILE", "PENGUIN", "CHEETAH", "RHINOCEROS", "OCTOPUS" };

        string[] movieWords = { "ACTION", "COMEDY", "DRAMA", "HORROR", "MYSTERY", "ROMANCE", "THRILLER", "ADVENTURE", "ANIMATION", "TELEVISION" };

        string actualWord = "";
        string showWord = "";
        string guessedLetters = "";
        int wrongGuesses = 0;
        int maxWrong = 6;

        //Main Menu
        Console.WriteLine("--SUPER ADVANCED HANGMAN GAME--");
        Console.WriteLine("Choose a subject!");
        Console.WriteLine("1. US History");
        Console.WriteLine("2. Animals");
        Console.WriteLine("3. Movies and Television");
        Console.WriteLine("Please enter a number between 1 and 3.");

        string choice = Console.ReadLine();

        Random random = new Random();

        //if statement to control category selection and word
        if (choice == "1")
        {
            Console.WriteLine("\nCategory Selected: US History");
            actualWord = historyWords[random.Next(historyWords.Length)];
        }
        else if (choice == "2")
        {
            Console.WriteLine("\nCategory Selected: Animals");
            actualWord = animalWords[random.Next(animalWords.Length)];
        }
        else if (choice == "3")
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\nCategory Selected: Movies and TV");
            actualWord = movieWords[random.Next(animalWords.Length)];
        }
        else
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\nInvalid Choice, defaulting to ANIMALS.");
            actualWord = animalWords[random.Next(animalWords.Length)];
        }
        //for loop for underscores
        for (int i = 0; i < actualWord.Length; i++)
        {
            showWord += "_";
        }
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("The word has " + actualWord.Length + " letters!!!");
        Console.WriteLine("You have " + maxWrong + " wrong guesses! Use them wisely...");

        //Actual game loop in a while loop that goes until the word is complete or player runs out of maxGuess
        while (wrongGuesses < maxWrong && showWord.Contains("_"))
        {
            Console.WriteLine("\nWord: " + showWord);
            Console.WriteLine("Wrong guesses: " + wrongGuesses + "/" + maxWrong);
            Console.WriteLine("Guessed letter: " + guessedLetters);
            Console.Write("Enter your guess (ONE LETTER ONLY!)>>> ");

            //RECIEVE INPUT and make uppercase
            string guess = Console.ReadLine().ToUpper();

            //Check if letter was already guessed
            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You already guess " + guess + "!");
                continue;
            }
            //Add the guess to guessed letters
            guessedLetters += guess + " ";

            //Check if the guess was correct
            if (actualWord.Contains(guess))
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("\nCORRECT! '" + guess + "' is in the word!");

                //Generate new display but with the revealed letters
                string newDisplay = "";
                for (int i = 0; i < actualWord.Length; i++)
                {
                    //convert char to string to compare
                    if (actualWord[i].ToString() == guess)
                    {
                        newDisplay += guess;
                    }
                    else
                    {
                        newDisplay += showWord[i];
                    }
                }
                showWord = newDisplay;
            }
            else
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("\nSorry, '" + guess + "' is not in the word!!!");
                wrongGuesses++;
                Console.WriteLine("Wrong guesses left: " + (maxWrong - wrongGuesses));
            }
        }
        //Game end which handles if player wins or loses
        Console.WriteLine("\n---Game Over!---");

        if (!showWord.Contains("_"))
        {
            Console.WriteLine("WOOHOO YOU WIN!!!");
            Console.WriteLine("The word was: " + actualWord);
        }
        else
        {
            Console.WriteLine("YOU LOSE! You ran out of guesses!");
            Console.WriteLine("The word was: " + actualWord);
        }
        Console.WriteLine("Thanks for playing C# hangman!");
    }
}