//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int[] numbers = new int[3];
//Console.WriteLine("index of 0 is " +numbers[0]);
//Console.WriteLine("index of 1 is " + numbers[1]);
//Console.WriteLine("index of 2 is " + numbers[2]);

//numbers[0] = 34;
//numbers[1] = 67;
//numbers[2] = 90;
//Console.WriteLine();
//Console.WriteLine("index of 0 is " + numbers[0]);
//Console.WriteLine("index of 1 is " + numbers[1]);
//Console.WriteLine("index of 2 is " + numbers[2]);

//var num = new[] { 43, 85, 7, 10, 72 };
//int sum = 0;
//for(int i =0; i< num.Length; i++)
//{
//    sum += num[i];
//}
//Console.WriteLine($"sum is: {sum}");

//char[] letter = { 'd', 'g','l'};
//for(int j =0; j<letter.Length; j++)
//{
//    Console.WriteLine(letter[j]);
//}

////----------two dimentional array-------

//char[,] letterArr = new char[2, 3];

//letterArr[0, 0] = 'A';
//letterArr[0, 1] = 'b';
//letterArr[0, 2] = 'c';
//letterArr[1, 0] = 'd';
//letterArr[1, 1] = 'e';
//letterArr[1, 2] = 'f';

//var height = letterArr.GetLength(0);
//var width = letterArr.GetLength(1);

//for(int i=0; i<height; i++)
//{
//    for(int j=0; j<width; j++)
//    {
//        Console.WriteLine($" the element of [{i},{j}] is: {letterArr[i,j]}");
//    }
//}
//Console.WriteLine();



//var letter2Arr = new char[,]
//{
//    {'a','b','c' },
//    {'d', 'e', 'f'},
//};

//var height2 = letter2Arr.GetLength(0);
//var width2 = letter2Arr.GetLength(1);

//for (int i = 0; i < height; i++)
//{
//    for (int j = 0; j < width; j++)
//    {
//        Console.WriteLine($" the element of [{i},{j}] is: {letter2Arr[i, j]}");
//    }
//}

//----for each loop----
var words = new[] { "Hello", "Good", "Happy", "Enjoy!" };

foreach (var word in words)
{
    Console.WriteLine(word);
}