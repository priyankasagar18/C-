Console.WriteLine("Hello, World!");
Console.WriteLine("Enter a point");
int point = int.Parse(Console.ReadLine());
//string result = ConvertPointToGrade(point);
char result = ConvertPointToGrade(point);
Console.WriteLine(result);

//string ConvertPointToGrade(int point)
//{
//    switch (point)
//    {
//        case 10:
//        case 9:
//        case 8:
//            return "A";
//        case 7:
//        case 6:
//            return "B";
//        case 5:
//        case 4:
//            return "C";
//        case 3:
//        case 2:
//        case 1:
//            return "D";
//        case 0:
//            return "F";
//        default:
//            return "!";
//    }
//}

//----------using char & with break----------
char ConvertPointToGrade(int point)
{
    char result;
    switch (point)
    {
        case 10:
        case 9:
        case 8:
            result = 'A';
            break;
        case 7:
        case 6:
            result=  'B';
            break;
        case 5:
        case 4:
            result = 'C';
            break;
        case 3:
        case 2:
        case 1:
            result = 'D';
            break;
        case 0:
            result = 'F';
            break;
        default:
            result = '!';
            break;
    }
    return result;
}