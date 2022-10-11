//Напишите программу, которая задает массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1,2,5,7,19]
//6, 1, 33 -> [6,1,33]

/* С указанием размера массива
static int GetUserArrayLength(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

static int[] FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        while (true)
    {
        Console.Write($"Enter number #{index + 1}: ");
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out array[index]);
        if (isCorrect)
            break;
        Console.WriteLine("Please, enter integer.");
    }
    }
    return array;
}

static void PrintArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]}, ");
    Console.Write($"{array[array.Length - 1]} -> [");
    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]},");
    Console.WriteLine($"{array[array.Length - 1]}]");
}


Console.Clear();
int userArrayLength = GetUserArrayLength("Enter array length: ", "Please, enter integer.");
int[] userArray = new int[userArrayLength];
FillArray(userArray);
Console.Clear();
PrintArray(userArray);
*/



static int[] FillArray(int[] qwe)
{
    int index = 0;
    Console.WriteLine("Enter array data.");

    while (true)
    {
        string userArrayData = Console.ReadLine() ?? "";
        if (int.TryParse(userArrayData, out int userData))
        {
            Array.Resize(ref qwe, index + 1);
            qwe[index] = userData;
            index++;
        }
        else
        {
            userArrayData = userArrayData.ToLower();
            if (userArrayData == "q")
                return qwe;
            else
                Console.WriteLine("Error");
        }
    }
}

static void PrintArray(int[] array)
{
    int length = array.Length;

    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]}, ");

    Console.Write($"{array[array.Length - 1]} -> [");

    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]},");

    Console.WriteLine($"{array[array.Length - 1]}]");
}

Console.Clear();
int[] userArray = new int[0];
userArray = FillArray(userArray);
Console.Clear();
PrintArray(userArray);