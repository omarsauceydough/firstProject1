internal class Program
{
    private static void Main(string[] args)
    {
        //Greet user and prompt for year #
        Console.Write("Welcome to the hyper advanced leap year program! Please enter any year >> ");
int year = int.Parse(Console.ReadLine());

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