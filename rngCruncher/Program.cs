internal class Program
{
    private static void Main(string[] args)
    {
        //Welcome program starter user whatever
        Console.WriteLine("Welcome to the RNG Cruncher Tool!");

        //Create 10 element int array
        int[] numbers = new int[10];

        //Populate array with for loop with random numbers between 1 and 100
        Random rand = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 100);
        }

        //Display populated table
        Console.WriteLine("Generated Numbers:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("----------------------------------------------------");
    }
}