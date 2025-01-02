// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
//Console.WriteLine("Hello!");
//Console.WriteLine("Hello!");

//var firstname = "Priyanka";
//Console.WriteLine(firstname);
//firstname = "Priya";
//Console.WriteLine(firstname);

//int a = 20;
//int b = 5;

//Console.WriteLine($"Addition: {a+b}");
//Console.WriteLine($"Substraction: {a-b}");
//Console.WriteLine("Multiplication:" + a*b);
//Console.WriteLine("Division:" + a/b);

//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");
//Console.WriteLine("What do you want to do?");

//string UserChoice = Console.ReadLine();
//Console.WriteLine("User Input: "+UserChoice);

//switch (UserChoice)
//{
//    case "S":
//        Console.WriteLine("seel all kf");
//        break;
//}

//UserChoice = "ABC";

////--------boolean operator

//bool isUserChoiceABC = UserChoice == "ABC";
//bool isUserChoiceNotABC = UserChoice != "ABC";
//Console.WriteLine(isUserChoiceNotABC);

//bool isUserChoiceNotABC2 = !(UserChoice == "ABC");
//Console.WriteLine(isUserChoiceNotABC2);

//var number = 10;

//var isLargerthan5 = number > 5; 
//var isSmallerthan10 = number < 10;
//var isLargerOrEqual10 = number >= 10;
//var isSmallerOrEqual6 = number <= 6;

//var is10Module3is1 = 10 % 3 == 1;

//Console.ReadKey();


//---------if else condition varible scope------

//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");
//Console.WriteLine("What do you want to do?");

//string UserChoice = Console.ReadLine();

//var result = add(5, -10);
//Console.WriteLine(result);

//bool isLong = IsLong(UserChoice);

////-------- 1st way ----------
////bool IsLong(string input)
////{
////    if (input.Length > 10) { 
////        return input.Length > 10;
////    }
////    return false;
////}

////-----------shortcut way-------
//bool IsLong(string input)
//{
//    return input.Length > 10;   
//}



////--------Mehtod---------
//if (UserChoice == "A")
//{
//    PrintSelectedOption("Add a Todo");
//}
//else if(UserChoice == "S")
//{
//    PrintSelectedOption("See all Todos" );
//}
//else if(UserChoice == "R")
//{
//    PrintSelectedOption("Removed a Todo");
//}
//else if(UserChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}
//else
//{
//    PrintSelectedOption("Incorrect choice!");
//}
//Console.ReadKey();

//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine($"Selected Option: {selectedOption}");
//}

int add(int a, int b)
{
    if (a > b)
    {
        return a + b;
    }
    return a;
}

//---------Parsing a string to int--------
Console.WriteLine("Enter a number");
string input= Console.ReadLine();


int number = int.Parse(input);
int number1 = Convert.ToInt32(input);

Console.WriteLine("using Parse method:" + number);
Console.WriteLine("using Convert method:" + number1);

//------convert int to string------
string numToString = number.ToString();
Console.WriteLine("int to stirng:" + numToString);

