// Data Types and Variables
int x;
int y;

x = 7;
y = x + 3;

Console.WriteLine(y);
Console.ReadLine();

Console.WriteLine("What is your name?");
Console.Write("Type your first name: ");
string myFirstName;
myFirstName = Console.ReadLine();

string myLastName;
Console.Write("Type your last name: ");
myLastName = Console.ReadLine();

Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
Console.ReadLine();

// If Decisions
Console.WriteLine("Bob's Big Giveaway");
Console.Write("Choose a door: 1, 2 or 3: ");
string userValue = Console.ReadLine();

string message = "";

if (userValue == "1")
{
    message = "You won a new car!";
}
else if (userValue == "2")
{
    message = "You won a new boat!";
}
else if (userValue == "3")
{
    message = "You won a new cat!";
}
else
{
    message = "Sorry, we didn't understand! ";
    message += "You lose!";
}

Console.WriteLine(message);
Console.ReadLine();

// Conditional Operator
Console.WriteLine("Bob's Big Giveaway");
Console.Write("Choose a door: 1, 2 or 3: ");
string userValue1 = Console.ReadLine();

string message1 = (userValue1 == "1") ? "boat" : "strand of lint";
Console.WriteLine("You won a {0}.", message1);
Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue1, message1);

// For Iteration
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7)
    {
        Console.WriteLine("Found seven!");
        break;
    }
}
