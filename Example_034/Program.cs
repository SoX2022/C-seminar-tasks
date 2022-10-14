//Задайте массив заполненный случайными положитеотными трехзначными числами. Напишите программу, которая покажет кол-во четных чисел в массиве.
//[345,897,568,234] -> 2



static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber) && userNumber > 0;
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

static int[] RandomArray(int arrayLength)
{
    int[] randomArray = new int[arrayLength];

    for (int index = 0; index < arrayLength; index++)
    {
        int randomPlusMinus;

        while (true)
        {
            randomPlusMinus = new Random().Next(-1, 2);
            if (randomPlusMinus != 0)
                break;
        }

        randomArray[index] = new Random().Next(100, 1000) * randomPlusMinus;
    }

    return randomArray;
}

static void EvenValueCounter(int[] array)
{
    int count = 0;

    foreach (int element in array)
    {
        if (element % 2 == 0)
            count++;
    }
    Console.WriteLine(count);
}

static void PrintArray(int[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]},");
    Console.Write($"{array[array.Length - 1]}]");
}


Console.Clear();
int length = GetNumberFromUser("Enter array length: ", "Error. Array length must have positive value.");
int[] array = RandomArray(length);

Console.Clear();
PrintArray(array);
Console.Write(" -> ");
EvenValueCounter(array);
