internal class Program
{
    private static void Main(string[] args)
    {
        //Create the list
        List<string> Fruits = new List<string> { "Apples", "Oranges", "Strawberries", "Mangos", "Guavas" };

        //Use forloop to print list
        Console.WriteLine("List of food before any changes:");
        foreach (string fruit in Fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine("----------------------------------");

        //Addition of 2 more fruits
        Fruits.Add("Pineapples");
        Fruits.Add("Grapes");

        //Display the list after adding pineapples and grapes
        Console.WriteLine("\nList after adding Pineapples and Grapes:");
        foreach (string fruit in Fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine("----------------------------------");

        //Remove 1 (wan) fruit from the list 
        Fruits.Remove("Oranges");

        //Display list after removing oranges
        Console.WriteLine("\nAfter removing Oranges:");
        foreach (string fruit in Fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine("----------------------------------");

        //Three different methods (Contains, Sort, Reverse)
        //Using contains method to test for item in a list
        bool hasApples = Fruits.Contains("Apples");
        Console.WriteLine($"\nDoes the list CONTAIN Apples?: {hasApples}");
        Console.WriteLine("----------------------------------");

        //Using sort method to sort items in alphabetical order
        Fruits.Sort();
        Console.WriteLine("\nList after reversing order: ");
        foreach (string fruit in Fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine("----------------------------------");

        //Using reverse method to display the items in reverse
        Fruits.Reverse();
        Console.WriteLine("\nList in reverse order:");
        foreach (string fruit in Fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine("----------------------------------");

        //Final message
        Console.WriteLine("\nThere you have it! Thanks for running!");
    }
}