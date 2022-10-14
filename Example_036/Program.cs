//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
//[3,7,23,12] -> 19
//[-4,-6,89,6] -> 0


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

static void OddIndexValueCalculator(int[] array)
{
    int sum = 0;

    for (int index = 1; index < array.Length; index += 2)
        sum += array[index];

    Console.WriteLine(sum);
}

static void PrintArray(int[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]},");
    Console.Write($"{array[array.Length - 1]}]");
}


int length;
int max;
Console.Clear();

while (true)
{
    length = GetNumberFromUser("Enter array length: ", "Error. Try again.");
    if (length > 0)
        break;
    else Console.WriteLine("Error. Array length must have positive value.");
}

int min = GetNumberFromUser("Enter min value for your array: ", "Error. Try again.");

while (true)
{
    max = GetNumberFromUser("Enter max value for your array: ", "Error. Try again.");
    if (max > min)
        break;
    else Console.WriteLine("Error. Max value must be higher then min value.");
}

int[] array = RandomArray(length, min, max);

Console.Clear();
PrintArray(array);
Console.Write(" -> ");
OddIndexValueCalculator(array);
