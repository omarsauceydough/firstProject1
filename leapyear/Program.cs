using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        int year = 0;
        bool validInput = false;
        while (!validInput)
        {
            //Greet user and prompt for year #
            Console.Write("Welcome to the hyper advanced leap year program! Please enter any year >> ");
            string input = Console.ReadLine();

            //check if input is valid and below 9999
            if (int.TryParse(input, out year))
            {
                if (year >= 1 && year <= 9999)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a year between 1 and 9999");
                    Console.WriteLine("Lets try again...\n");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number!");
                Console.WriteLine("Lets try again...\n");
            }
        }
        //Check for divisibility 
        bool divBy4 = year % 4 == 0;
        bool divBy100 = year % 100 == 0;
        bool divBy400 = year % 400 == 0;

        //Display divBy results (ternary tho)
        Console.WriteLine("Year entered: " + year);
        Console.WriteLine("Divisible by 4: " + (divBy4 ? "Yes" : "No"));
        Console.WriteLine("Divisible by 100: " + (divBy100 ? "Yes" : "No"));
        Console.WriteLine("Divisible by 400: " + (divBy400 ? "Yes" : "No"));

        //Determine if leap uear 
        if (divBy4 && (!divBy100 || divBy400))
        {
            Console.WriteLine("Leap year: Yes");
        }
        else
        {
            Console.WriteLine("Leap year: no");
        }
    }
}