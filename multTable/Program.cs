internal class Program
{
    private static void Main(string[] args)
    {
        //Set size = 12
        int size = 12;

        //Display ---12x12 Multiplication Table---
        Console.WriteLine("-----------12x12 Multiplication Table!-----------");

        //For loop for rows
        for (int row = 1; row <= size; row++)
        {
            //Write |
            Console.Write("|");

            //Nested for loop for columns
            for (int column = 1; column <= size; column++)
            {
                //Mult row by column to get product 
                int product = row * column;
                //Product + | for formatting
                Console.Write($"{product,3}|");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
