//Name gather
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("------------------------------------------------------------------------------------------");
Console.WriteLine("Welcome to the super advanced number inputter and outputter. Please enter your first name.");
Console.Write("First Name>>");
string firstName = Console.ReadLine();

Console.Write("Last Name>>");
string lastName = Console.ReadLine();

//greet
Console.WriteLine("Hello " + firstName + " " + lastName + "!");

int x, y, z;

//numbers
Console.Write("Enter a number for X>>");
string xInput = Console.ReadLine();
while (!int.TryParse(xInput, out x))
{
    Console.Write("Invalid! Enter a number for X>>");
    xInput = Console.ReadLine();
}
x = int.Parse(xInput);

Console.Write("enter a number for y: ");
string yInput = Console.ReadLine();
while (!int.TryParse(yInput, out y))
{
    Console.Write("Invalid! Enter a number for Y>>");
    yInput = Console.ReadLine();
}
y = int.Parse(yInput);

Console.Write("enter a number for z: ");
string zInput = Console.ReadLine();
while (!int.TryParse(zInput, out z))
{
    Console.Write("Invalid! Enter a number for Z>>");
    zInput = Console.ReadLine();
}
z = int.Parse(zInput);

// math and then print results
int a = x + y + z;
Console.WriteLine("a (x + y + z) = " + a);

int subtract = x - y;
Console.WriteLine("x - y = " + subtract);

int b = x * z;
Console.WriteLine("b (x * z) = " + b);

int divide = a / y;
Console.WriteLine("a / y = " + divide);

int mod = x % b;
Console.WriteLine("x % b = " + mod); //change