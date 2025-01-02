List<string> words = new List<string>();
words.Add("Priyanka");
words.Add("krinal");
words.Add("Hritu");
words.Add("Krishita");
words.Add("Lovely");

Console.WriteLine("count of the element is :" + words.Count);
Console.WriteLine();

var moreWords = new[] { "NewAdded!", "Update!" };
words.AddRange(moreWords);


words.AddRange(new [] { "second", "method!", "using" ,"shortcut" });

words.AddRange(new List<string> { "With", "new!", "List" });

Console.WriteLine("Index of element 'Krishita is' " + words.IndexOf("Krishita"));
Console.WriteLine("Index of element 'Krishita is' " + words.IndexOf("Neha")); // return -1 indicated such an element is not in list
Console.WriteLine();

Console.WriteLine("Check elemnet 'Hritu' ? "+words.Contains("Hritu"));
Console.WriteLine("Check elemnet 'Priya sagar' ? "+words.Contains("Priya sagar"));

foreach (string word in words)
{
    Console.WriteLine(word);
}
Console.WriteLine();

words.Clear();
Console.WriteLine("After clear count of the list: " + words.Count);

Console.WriteLine();



var myList = new List<string>
{
    "HELLO","Good!","ONE1","two","THREE","HELLO"
};
myList.Add("Prit");
myList.Add("wishlist");
myList.Add("Shrishti");
myList.Add("Darshita");
myList.Add("Heli");
Console.WriteLine("count of the element is :" + myList.Count);

myList[7] = "Priya";
myList.Remove("Shrishti");
myList.RemoveAt(1);




//myList[15] = "not working"; //----we can't modify or access the index out of range because 15 index is not there.

foreach (string word in myList)
{
    Console.WriteLine(word);
}
List<string> result = new List<string>();
foreach (string word in myList)
{
    
    if (word.All(char.IsUpper))
    {
        if (!result.Contains(word))
        {
            result.Add(word);
        }
       
    }

   
}
foreach (string word in result)
{
    Console.WriteLine("result is:" + word);
}
