//Name gather
Console.WriteLine("------------------------------------------------------------------------------------------");
Console.WriteLine("Welcome to the super advanced number inputter and outputter. Please enter your first name.");
Console.Write("First Name>>");
string firstName = Console.ReadLine();

Console.Write("Last Name>>");
string lastName = Console.ReadLine();

//greet
Console.WriteLine("Hello " + firstName + " " + lastName + "!");

//numbers
Console.Write("Enter a number for X>>");
string xInput = Console.ReadLine();
int x = int.Parse(xInput);

Console.Write("enter a number for y: ");
string yInput = Console.ReadLine();
int y = int.Parse(yInput);

Console.Write("enter a number for z: ");
string zInput = Console.ReadLine();
int z = int.Parse(zInput);

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
Console.WriteLine("x % b = " + mod);