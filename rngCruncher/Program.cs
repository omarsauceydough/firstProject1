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
            numbers[i] = rand.Next(1, 101);
        }

        //Display populated table
        Console.WriteLine("Generated Numbers:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("----------------------------------------------------");

        //Foreach loop to sum them up
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        //Mean
        double mean = (double)sum / 10;

        //Median
        Array.Sort(numbers);
        double median = (numbers[4] + numbers[5]) / 2.0;

        //Display results
        Console.WriteLine("Here are the numbers, but crunched.");
        Console.WriteLine("\n\nSum: " + sum);
        Console.WriteLine("Average: " + mean);
        Console.WriteLine("Median: " + median);
        Console.WriteLine("\nThanks for crunching random numbers!");
    }
}