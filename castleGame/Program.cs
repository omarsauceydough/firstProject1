internal class Program
{
    private static void Main(string[] args)
    {
        //Init RNG and playAgain string
        Random rand = new Random();
        string playAgain = "Y";

        ////While loop for playAgain

        while (playAgain == "Y")
        {
            //Set variable int 0 for doorsOpened
            //Set variable bool true for gameStart
            int doorsOpened = 0;
            bool gameStart = true;

            //Greet player
            Console.WriteLine("Welcome to the Kings Castle!");
            //While (still in the first while) (gameStart true)
            while (gameStart == true)
            {
                //Write "Input any number between 1-3!>> "
                Console.Write("Write any number between 1 and 3! >> ");
                //ReadLine and assign as int doorSelect
                string doorSelect = Console.ReadLine();
                //use RNG (1-3) to dictate outcome
                int outcome = rand.Next(1, 4);

                //Add 1 to doorsopened
                doorsOpened++;

                //outcome (if)
                if (outcome == 1)
                {
                    //IF outcome = king 
                    //WriteLine "You found the king!"
                    //Set gamestart false
                    Console.WriteLine("You found the king!!!");
                    Console.WriteLine("Doors opened: " + doorsOpened);
                    gameStart = false;
                }
                //ELSE IF outcome = treasure
                else if (outcome == 2)
                {
                    //Writeline "You found treasure! Not the king though."
                    Console.WriteLine("You found treasure! not the king though.");
                }
                //ELSE IF outcome = dragon 
                else if (outcome == 3)
                {
                    //Writeline "You found a hungry dragon! Game Over!"
                    //Set gameStart = false
                    Console.WriteLine("You found an evil hungry dragon! GAme Over!");
                    Console.WriteLine("Doors opened: " + doorsOpened);
                    gameStart = false;
                }
            }
            //Write "Do you want to play again? (Y/N) >> "
            //End if N, Restart if Y
            Console.WriteLine("Do you want to play again? (Y/N)");
            playAgain = Console.ReadLine();
        }
    }
}