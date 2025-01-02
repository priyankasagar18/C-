// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var numbers = new[] { 5, -7, 10, -16, 12 };
foreach (var number in numbers)
{
    Console.WriteLine(number);
}


var positvieNumbers = GetOnlyPositive(numbers, out int NonpositiveCount);
//foreach (var positiveNumber in positvieNumbers)
//{
//    Console.WriteLine("positive number is " +positiveNumber);
//}
Console.WriteLine(NonpositiveCount);

List<int> GetOnlyPositive(int[] numbers, out int countNonPositive)
{
    countNonPositive = 0;
    var result = new List<int>();
    foreach (var number in numbers)
    {
        if(number>0) result.Add(number);
        else
        {
            countNonPositive++;
        }
    }
    return result;
}


