//Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4,-8,8,2] -> [4,8,-8,-2]


static int GetNumberFromUser(string message, string errorMessage)
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

static int[] RandomArray(int arrayLength, int minValue, int maxValue)
{
    int[] randomArray = new int[arrayLength];

    for (int index = 0; index < arrayLength; index++)
    {
        randomArray[index] = new Random().Next(minValue, maxValue + 1);
    }

    return randomArray;
}

static void PrintArray(int[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]},");
    Console.Write($"{array[array.Length - 1]}]");
}

static void ArrayElementSwap(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = array[index] * (-1);
    }
}


int length;
Console.Clear();

while (true)
{
    length = GetNumberFromUser("Enter array length: ", "Error. Try again.");
    if (length > 0)
        break;
    else Console.WriteLine("Error. Array length must have positive value.");
}

int min = GetNumberFromUser("Enter min value for your array: ", "Error");
int max = GetNumberFromUser("Enter max value for your array: ", "Error");
int[] array = RandomArray(length, min, max);
PrintArray(array);
Console.Write(" -> ");
ArrayElementSwap(array);
PrintArray(array);
