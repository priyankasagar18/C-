// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter a number:");
var userInput = Console.ReadLine();

bool isParsingSuccessful = int.TryParse(userInput, out int number);

if (isParsingSuccessful)
{
    Console.WriteLine("parsing is successfull and the number is: " + number);
}
else
    Console.WriteLine("Parsing is failed. " + number); //number is set by default 0

Console.WriteLine();

bool isParsing_Successful;
do
{
    Console.WriteLine("Enter a number");
    var userInput2 = Console.ReadLine();

    isParsing_Successful = int.TryParse(userInput2, out int number2);
    if (isParsingSuccessful)
    {
        Console.WriteLine("Parsing is successfull and number is: "+ number2);
    }
    else
    {
        Console.WriteLine("parsing is not successfull");
    }
}while(!isParsing_Successful);