//Prompt user for a nubmer
Console.WriteLine("enter a number!");

//read and store the number
int number = convert.toint(Console.Readline());

// tell the user what is happening
console.writeline($"Multiplication table for {number}:");

//for loop to start at 1 and end at 10 that goes up by 1
for (int i = 0; i <= 12; i++)
{
    //mmutliply the user number by the loop counter
    int result = number * i;
    //display the result in a formatted way 
    Console.WriteLine($"{number} * {i} = {result}");
}

//let the user knw that the program is finished
Console.WriteLine("Program finished!");