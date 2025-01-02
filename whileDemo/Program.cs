// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//var number = 0;
////while (number < 10)
////{
////    number ++;
////    Console.WriteLine(number);
////}
//int sum = 0;
//while (number < 10)
//{
//    // sum = sum + number++;
//    sum = sum + ++number;
//    Console.WriteLine(sum);
//    Console.WriteLine($"number is: {number}");

//}


//-----------do While-----------
string userInput;
do
{
    Console.WriteLine("Enter a word of length more than 10 ");
    userInput = Console.ReadLine();
    Console.WriteLine(userInput);

} while (userInput.Length <= 10);
Console.WriteLine("loop is finished");

//if we try to implement do..while code with using while then first we have to initalize userInput

//string userInput = "";
//while (userInput.Length <= 10) // if condition is length > 3 then not right to use while so use do..while
//{
//    Console.WriteLine("Enter a word of length more than 10 ");
//    userInput = Console.ReadLine();
//    Console.WriteLine(userInput);
//}