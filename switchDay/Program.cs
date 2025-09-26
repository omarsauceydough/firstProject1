internal class Program
{
    private static void Main(string[] args)
    {
        //prompt user for a number between 1-7 corresponding to a weekday 
        Console.Write("Please enter a number between 1-7! (1: Monday - 7: Sunday)>> ");
        int day = int.Parse(Console.ReadLine());

        //switch statement
        switch (day)
        {
            case 1:
                Console.WriteLine("ACK! I hate mondays!");
                break;

            case 2:
                Console.WriteLine("It's Tuesday!");
                break;

            case 3:
                Console.WriteLine("Hump Daaaaay!");
                break;

            case 4:
                Console.WriteLine("It's Thursday!");
                break;

            case 5:
                Console.WriteLine("TGIF!");
                break;

            case 6:
            case 7:
                Console.WriteLine("It's the weekend!");
                break;

            default:
                Console.WriteLine("Please enter a number between 1-7.");
                break;
        }
    }
}