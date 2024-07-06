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

// Arrays
int[] numbers = new int[5];

numbers[0] = 4;
numbers[1] = 8;
numbers[2] = 15;
numbers[3] = 16;
numbers[4] = 23;

Console.WriteLine(numbers[1]);
Console.WriteLine(numbers.Length);

int[] numbers1 = new int[] { 4, 8, 15, 16, 23, 42 };
string[] names = new string[] { "John", "Michael", "Bob", "David" };

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

foreach (string name in names)
{
    Console.WriteLine(name);
}

string zig = "You can get what you want out of life " + 
    "if you help enough other people get what they want.";

char[] charArray = zig.ToCharArray();
Array.Reverse(charArray);

foreach (char zigChar in charArray)
{
    Console.Write(zigChar);
}

// Defining and Calling Methods
using System;

class Program
{
    public static void Main(string[] args)
    {
        HelloWorld();
        DisplayResult("My name is Ivan M.");
        DisplayResult(ReverseString("Ivan") + " " + ReverseString("Milenkovic") + " " + ReverseString("Miami"));
        DisplayResult(ReverseString("Ivan"), ReverseString("Milenkovic"), ReverseString("Miami"));
    }

    private static void HelloWorld()
    {
        Console.WriteLine("Hello World");
    }

    private static string ReverseString(string message)
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        return String.Concat(messageArray);
    }

    private static void DisplayResult(string firstName, string lastName, string cityName)
    {
        Console.Write(String.Format("{0} {1} from {2}", firstName, lastName, cityName));
    }

    private static void DisplayResult(string message)
    {
        Console.WriteLine(message);
    }

}
