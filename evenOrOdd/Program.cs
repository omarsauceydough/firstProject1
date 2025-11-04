internal class Program
{
    private static void Main(string[] args)
    {
        //Greet user and ask for a number 
        Console.WriteLine("Welcome to the Even or Odd number calculator! Please enter a number >> ");

        int number = 0;
        bool validInput = false;

        while(!validInput)
        {
            try
            {
                Console.Write("Please enter a number >>");
                number = int.Parse(Console.ReadLine());
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Thats not a valid number! Please try again");
            }
            catch (Exception)
            {
                Console.WriteLine("An unknown error occured.");
            }
        }

        //switch for determining even or odd, which produces result 
        switch (number % 2)
        {
            case 0:
                Console.WriteLine(number + " is even!");
                break;
            case 1:
                Console.WriteLine(number + " is odd!");
                break;
        }
    }
}