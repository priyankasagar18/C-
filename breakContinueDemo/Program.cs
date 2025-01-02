// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"i is {i}");
    if (i > 25)
    {
        break;
    }
}

int number;
do
{
    Console.WriteLine("Enter a number greater than 10");
    var userInput = Console.ReadLine();
    if (userInput == "stop")
    {
        break;
    }
    number = int.Parse(userInput);
    Console.WriteLine("user input is: "+userInput );

} while (number < 10);

//-------Continue--------
for (int i = 0; i < 20; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    Console.WriteLine($"i is : {i}");
}

int number2;
do
{
    Console.WriteLine("Enter a number greater than 10");
    var userInput = Console.ReadLine();
    if (userInput == "stop")
    {
        break;
    }
    bool isParsableToInt = userInput.All(char.IsDigit);
    if (!isParsableToInt)
    {
        number2 = 0;
        continue;
    }

    number2 = int.Parse(userInput);
    Console.WriteLine(number2);

} while (number2 < 10);

//----------nested for loop---------
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"i is {i} j is {j}");
    }
}