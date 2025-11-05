internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Methodical Calculator!");

        //Bool to control the main prog loop
        bool keepRunning = true;

        while (keepRunning)
        {
            //Menu options display
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Please enter your choice 1-5 :)");

            string menuChoice = Console.ReadLine();

            //Handle menu selection 
            switch (menuChoice)
            {
                case "1":
                    AddNumbers();

                    break;
                case "2":
                    SubtNumbers();

                    break;
                case "3":
                    MultNumbers();

                    break;
                case "4":
                    DivNumbers();

                    break;
                case "5":
                    keepRunning = false;

                    Console.WriteLine("Exiting. Have a nice day!");

                    break;
                default:
                    Console.WriteLine("ERROR! Please select a number between 1-5!");
                    break;
            }
        }
    }

    //Method for addition
    static void AddNumbers()
    {
        Console.Write("Enter first number>> ");
        double num1 = GetNumber();

        Console.Write("Enter a second number>> ");
        double num2 = GetNumber();

        double result = num1 + num2;
        Console.WriteLine($"Result: {num1} + {num2} = {result}");
        WaitForAnyKey();
    }

    //Method for subtraction
    static void SubtNumbers()
    {
        Console.Write("Enter first number>> ");
        double num1 = GetNumber();

        Console.Write("Enter a second number>> ");
        double num2 = GetNumber();

        double result = num1 - num2;
        Console.WriteLine($"Result: {num1} - {num2} = {result}");
        WaitForAnyKey();
    }

    //Method for multiplying
    static void MultNumbers()
    {
        Console.Write("Enter first number>> ");
        double num1 = GetNumber();

        Console.Write("Enter a second number>> ");
        double num2 = GetNumber();

        double result = num1 * num2;
        Console.WriteLine($"Result: {num1} x {num2} = {result}");
        WaitForAnyKey();
    }

    //Method for dividing
    static void DivNumbers()
    {
        Console.Write("Enter first number>> ");
        double num1 = GetNumber();

        Console.Write("Enter a second number>> ");
        double num2 = GetNumber();

        if (num2 == 0)
        {
            Console.WriteLine($"ERROR! Cannot divide by zero!");
        }
        else
        {
            double result = num1 / num2;
            Console.WriteLine($"Result: {num1} / {num2} = {result}");
            WaitForAnyKey();
        }
    }
    static double GetNumber()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                return number;
            }
            else
            {
                Console.Write("ERROR! Number invalid, try again! >>");
            }
        }
    }

    //Method that lets the user read the output, then move forward at their will. 
    static void WaitForAnyKey()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}