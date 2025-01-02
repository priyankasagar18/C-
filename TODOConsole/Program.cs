using System;

Console.WriteLine("Hello");
var userInput = "";
List<string> AddResult = new List<string>();
do
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    userInput = Console.ReadLine();

    if(userInput.ToUpper() == "A")
    {
        var addInput = "";
      
        do {
            Console.WriteLine("Enter the todo Discription");
            addInput = Console.ReadLine();
            Console.WriteLine();

           
             if (addInput.Length == 0)
            {
                Console.WriteLine("The discription can not be empty");
            }
            else
            {
                AddResult = AddTodosList(addInput);
               
            }
        } while (addInput.Length == 0  );
    }
    else if(userInput.ToUpper() == "S") {
        Console.WriteLine("list of all todos:");
        Console.WriteLine();
        if (AddResult.Count == 0)
        {
            Console.WriteLine("No TODOs have been added yet");
            Console.WriteLine();
        }
        for (int i = 0; i < AddResult.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + AddResult[i]);
           
        }
        Console.WriteLine();

    }
    else if(userInput.ToUpper() == "R")
    {
        
      
        bool isParsingSuccessful;
        int parsedNumber;
        do
        {
            Console.WriteLine("Select the index of the TODO you want to remove:");
            Console.WriteLine();
            if (AddResult.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet");
                break;

            }
            for (int i = 0; i < AddResult.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + AddResult[i]);
            }
            var indexOfRemoveItem = Console.ReadLine();
            isParsingSuccessful = int.TryParse(indexOfRemoveItem, out parsedNumber);
            if (indexOfRemoveItem == "")
            {
                Console.WriteLine("Selected index cannot be empty");
            }
           
            else if (isParsingSuccessful && parsedNumber > 0 && parsedNumber <= AddResult.Count)
            {
                var removedItem = AddResult[parsedNumber - 1];
                AddResult.RemoveAt(parsedNumber - 1);
                Console.WriteLine("TODO Removed: " + removedItem );              
            }
            else
            {
                Console.WriteLine("The given index is not valid.");
                Console.WriteLine();

            }
        } while (!isParsingSuccessful || parsedNumber <= 0 || parsedNumber >AddResult.Count  );

       
    }
    else
    {
        Console.WriteLine("Incorrect Input");
    }
    //switch (userInput.ToUpper())
    //{
    //    case "S":
    //        Console.WriteLine("See all todos");
    //        break;
    //    case "A":
    //        Console.WriteLine("Add a todo");
    //        var addInput = Console.ReadLine();
    //        AddResult = AddTodosList(addInput);
    //        break;
    //    case "R":
    //        Console.WriteLine("Remove todo");
    //        break;
    //    default:
    //        Console.WriteLine("Invalid choice");
    //        break;
    //}

} while (userInput.ToUpper() != "E");



List<string> AddTodosList(string todos)
{
    List<string> result = AddResult;
    if(!result.Contains(todos)) {
        result.Add(todos);
        Console.WriteLine("TODO successfully added: " + todos);

    }
    else
    {
        Console.WriteLine("The discription must be unique");
    }
    return result;
}


