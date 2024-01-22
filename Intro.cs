// Consolas and Telim
//using static System.Runtime.InteropServices.JavaScript.JSType;
//using System.Diagnostics.Metrics;

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

Console.WriteLine("Bread is ready.");
Console.WriteLine("Who is the bread for?");
string name = Console.ReadLine();
Console.WriteLine("Noted: " + name + " got bread.");

// The Triangle Farmer
Console.WriteLine("Enter triangle’s base size: ");
double triangleBase = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter triangle’s height: ");
double triangleHeight = Convert.ToDouble(Console.ReadLine());

double area = triangleBase * triangleHeight / 2;
Console.WriteLine($"Area of the triangle is {area}.");

// The Four Sisters and the Duckbear
Console.WriteLine("Enter the number of chocolate eggs: ");
int eggs = Convert.ToInt32(Console.ReadLine());

int eggsForEachSister = eggs / 4;
int eggsForDuckbear = eggs % 4;
Console.WriteLine($"Each sister should get {eggsForEachSister} egg(s).");
Console.WriteLine($"The duckbear should get {eggsForDuckbear} egg(s).");

// The Dominion of Kings
Console.Write("How many provinces do you have? ");
int provinces = Convert.ToInt32(Console.ReadLine());
Console.Write("How many duchies do you have? ");
int duchies = Convert.ToInt32(Console.ReadLine());
Console.Write("How many estates do you have? ");
int estates = Convert.ToInt32(Console.ReadLine());

int total = provinces * 6 + duchies * 3 + estates;
Console.WriteLine($"You have {total} points in total!");

// The Defense of Consolas
Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Deploy to: \n({row}, {column - 1}) \n({row - 1}, {column}) \n({row}, {column + 1}) \n({row + 1}, {column})");
// Console.Beep(100, 1000);

// Repairing the Clocktower
Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) Console.WriteLine("Tick");
else Console.WriteLine("Tock");

// Watchtower
Console.Write("Enter x value: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y value: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 && y == 0) Console.WriteLine("The enemy is here!");
if (x == 0 && y > 0) Console.WriteLine("The enemy is to the north!");
if (x == 0 && y < 0) Console.WriteLine("The enemy is to the south!");
if (x > 0 && y == 0) Console.WriteLine("The enemy is to the east!");
if (x > 0 && y > 0) Console.WriteLine("The enemy is to the northeast!");
if (x > 0 && y < 0) Console.WriteLine("The enemy is to the southeast!");
if (x < 0 && y == 0) Console.WriteLine("The enemy is to the west!");
if (x < 0 && y > 0) Console.WriteLine("The enemy is to the northwest!");
if (x < 0 && y < 0) Console.WriteLine("The enemy is to the southwest!");

// Buying Inventory
Console.Write("The following items are available: \n1 – Rope\n2 – Torches\n3 – Climbing Equipment\n4 – Clean Water\n5 – Machete\n6 – Canoe\n7 – Food Supplies\nWhat number do you want to see the price of? ");
int itemNumber = Convert.ToInt32(Console.ReadLine());

switch (itemNumber)
{
    case 1:
        Console.WriteLine("Rope cost 10 gold");
        break;
    case 2:
        Console.WriteLine("Torches cost 15 gold");
        break;
    case 3:
        Console.WriteLine("Climbing Equipment cost 25 gold");
        break;
    case 4:
        Console.WriteLine("Clean Water cost 1 gold");
        break;
    case 5:
        Console.WriteLine("Machete cost 20 gold");
        break;
    case 6:
        Console.WriteLine("Canoe cost 200 gold");
        break;
    case 7:
        Console.WriteLine("Food Supplies cost 1 gold");
        break;
    default:
        Console.WriteLine("Wrong number");
        break;
}

// Discounted Inventory
Console.Write("The following items are available: \n1 – Rope\n2 – Torches\n3 – Climbing Equipment\n4 – Clean Water\n5 – Machete\n6 – Canoe\n7 – Food Supplies\nWhat number do you want to see the price of? ");
int itemNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your name: ");
string yourName = Console.ReadLine();

if (yourName == "Ivan")
{
    switch (itemNumber1)
    {
        case 1:
            Console.WriteLine($"Rope cost {10 / 2} gold");
            break;
        case 2:
            Console.WriteLine($"Torches cost {(float)15 / 2} gold");
            break;
        case 3:
            Console.WriteLine($"Climbing Equipment cost {(float)25 / 2} gold");
            break;
        case 4:
            Console.WriteLine($"Clean Water cost {(float)1 / 2} gold");
            break;
        case 5:
            Console.WriteLine($"Machete cost {20 / 2} gold");
            break;
        case 6:
            Console.WriteLine($"Canoe cost {200 / 2} gold");
            break;
        case 7:
            Console.WriteLine($"Food Supplies cost {(float)1 / 2} gold");
            break;
        default:
            Console.WriteLine("Wrong number");
            break;
    }
}
else
{
    switch (itemNumber1)
    {
        case 1:
            Console.WriteLine("Rope cost 10 gold");
            break;
        case 2:
            Console.WriteLine("Torches cost 15 gold");
            break;
        case 3:
            Console.WriteLine("Climbing Equipment cost 25 gold");
            break;
        case 4:
            Console.WriteLine("Clean Water cost 1 gold");
            break;
        case 5:
            Console.WriteLine("Machete cost 20 gold");
            break;
        case 6:
            Console.WriteLine("Canoe cost 200 gold");
            break;
        case 7:
            Console.WriteLine("Food Supplies cost 1 gold");
            break;
        default:
            Console.WriteLine("Wrong number");
            break;
    }
}

// The Prototype
Console.Write("User 1, enter a number between 0 and 100: ");
int number1 = Convert.ToInt32(Console.ReadLine());

while (number1 < 0 || number1 > 100)
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    number1 = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

Console.Write("User 2, guess the number.\nWhat is your next guess? ");
int number2 = Convert.ToInt32(Console.ReadLine());

while (number1 != number2)
{
    if (number1 < number2)
    {
        Console.WriteLine($"{number2} is too high");
        Console.Write("What is your next guess? ");
        number2 = Convert.ToInt32(Console.ReadLine());
    }
    if (number1 > number2)
    {
        Console.WriteLine($"{number2} is too low");
        Console.Write("What is your next guess? ");
        number2 = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("You guessed the number!");

// The Magic Cannon
for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}: Electric and Fire");
    }
    else if (i % 3 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
    else if (i % 5 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine($"{i}: Normal");
    }
}

// The Replicator of D’To
int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Enter a number: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}


int[] array1 = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array1[i] = array[i];
}

Console.WriteLine("First array: " + string.Join(", ", array));
Console.WriteLine("Second array: " + string.Join(", ", array1));

// The Laws of Freach
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int minValue = int.MaxValue;

foreach (int num in array)
{
    if (num < minValue) minValue = num;
}

Console.WriteLine($"Minimum value in the array is {minValue}");

int sum = 0;

foreach (int num in array)
{
    sum += num;
}

float averageValue = (float)sum / array.Length;

Console.WriteLine($"Average value of the array is {averageValue}");

// Taking a Number
int AskForNumber(string text)
{
    Console.Write(text);
    string answer = Console.ReadLine();
    int number = Convert.ToInt32(answer);
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());

    while (number < min || number > max)
    {
        Console.Write(text);
        number = Convert.ToInt32(Console.ReadLine());
    }

    return number;
}

// Countdown
void Countdown(int number)
{
    if (number == 1)
    {
        Console.WriteLine(1);
        return;
    }

    Console.WriteLine(number);
    Countdown(number - 1);
}

Countdown(10);

// Hunting the Manticore
int startingPointsManticore = 10;
int startingPointsCity = 15;
int currentPointsManticore = startingPointsManticore;
int currentPointsCity = startingPointsCity;
int round = 1;

Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

while (currentPointsManticore > 0 || currentPointsCity > 0)
{
    int damage = (round % 15 == 0) ? 10 : (round % 3 == 0 || round % 5 == 0) ? 3 : 1;
    displayStatus();

    Console.Write("Enter desired cannon range: ");
    int cannonRange = Convert.ToInt32(Console.ReadLine());
    
    string message = (cannonRange > distance) ? "That round OVERSHOT the target." : (cannonRange < distance) ? "That round FELL SHORT of the target." : "That round was a DIRECT HIT!";
    Console.WriteLine(message);

    if (distance == cannonRange) currentPointsManticore -= damage;
    if (currentPointsManticore > 0) currentPointsCity--;

    if (currentPointsManticore < 1)
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        break;
    }
    if (currentPointsCity < 1)
    {
        Console.WriteLine("The city of Consolas has been destroyed :(");
        break;
    }

    round++;
}

void displayStatus()
{
    int damage = (round % 15 == 0) ? 10 : (round % 3 == 0 || round % 5 == 0) ? 3 : 1;
    Console.WriteLine($"STATUS: Round: {round} City: {currentPointsCity}/{startingPointsCity} Manticore: {currentPointsManticore}/{startingPointsManticore}");
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
}
