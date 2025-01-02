Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userChoice = Console.ReadLine();

if (userChoice == "A" || userChoice == "a")
{
    Console.WriteLine(number1 + number2);
}
else if (userChoice.ToUpper() == "S")
{
    Console.WriteLine(number1 - number2);
}
else if (userChoice == "M" || userChoice == "m")
{
    Console.WriteLine(number1 * number2);
}
else
{
    Console.WriteLine("Invalid option");
}
Console.WriteLine("Press any key to close");
Console.ReadKey();

//--------2nd method---------
//if(EqaulCase(userChoice, "A"))
//{
//    int addition = number1 + number2;
//    PrintSolution(number1, number2, addition, "+");
//}
//else if (EqaulCase(userChoice, "S"))
//{
//    int subtract = number1 + number2;
//    PrintSolution(number1, number2, subtract, "-");
//}
//else if (EqaulCase(userChoice, "M"))
//{
//    int multiplication= number1 + number2;
//    PrintSolution(number1, number2, multiplication , "*");
//}
//else
//{
//    Console.WriteLine("Invalid input");
//}
//Console.WriteLine("Press any key to close");
//Console.ReadKey();

//bool EqaulCase(string left,  string right)
//{
//    return left.ToUpper() == right.ToUpper();
//}
//void PrintSolution(int num1, int num2, int result,string @operator)
//{
//    Console.WriteLine( $"{num1} {@operator} {num2} = {result} ");
//}
