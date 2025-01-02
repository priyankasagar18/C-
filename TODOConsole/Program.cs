bool shallExit = false;

List<string> todo = new List<string>();
Console.WriteLine("Hello");
while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userInput = Console.ReadLine();

    switch (userInput.ToUpper())
    {
        case "S":
            SeeAllTodos();
            break;
        case "A":
            AddTodo();
            break;
        case "R":
            RemoveTodo();
            break;
        case "E":
            shallExit = true;
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
    }
}

void SeeAllTodos()
{

    if (todo.Count == 0)
    {
        NoTodosAdded();
        return;
    }

    else
    {
        for (int i = 0; i < todo.Count; i++)
        {

            Console.WriteLine($"{i + 1}. {todo[i]}");
        }
    }
}

void AddTodo()
{
    string discription;
    do
    {
        Console.WriteLine("Enter the Todo Discription:");
        discription = Console.ReadLine();
    } while (!IsDiscriptionValid(discription));

    todo.Add(discription);
}

bool IsDiscriptionValid(string discription)
{
    if (discription == "")
    {
        Console.WriteLine("discription can not be empty");
        return false;
    }
    else if (todo.Contains(discription))
    {
        Console.WriteLine("Discription must be unique");
        return false;
    }
    return true;
}

void RemoveTodo()
{

    if (todo.Count == 0)
    {
        NoTodosAdded();
        return;
    }
    int index;
    do
    {

        Console.WriteLine("Select the index of the TODO you want to remove:");
        SeeAllTodos();

    } while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);

}

void RemoveTodoAtIndex(int index)
{

    var removedItem = todo[index];
    todo.RemoveAt(index);
    Console.WriteLine("Todo Removed:" + removedItem);

}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();


    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty");
        return false;
    }
    if (int.TryParse(userInput, out index) && index >= 1 && index <= todo.Count)
    {

        return true;
    }

    Console.WriteLine("The given index is not valid");
    return false;

}

static void NoTodosAdded()
{
    Console.WriteLine("No TODOs have been added yet");
}
