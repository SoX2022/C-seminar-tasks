//Задайте массив из 12 элевентов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементова массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, а сумма отрицательных равна -20.


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
    Console.WriteLine($"{array[array.Length - 1]}]");
}

static int GetArrayNegativeElementSum(int[] array)
{
    int arrayElementSum = 0;
    foreach (int element in array)
    {
        if (element < 0)
            arrayElementSum += element;
    }
    return arrayElementSum;
}

static int GetArrayPositiveElementSum(int[] array)
{
    int arrayElementSum = 0;
    foreach (int element in array)
    {
        if (element > 0)
            arrayElementSum += element;
    }
    return arrayElementSum;
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
Console.WriteLine($"Negative elements sum = {GetArrayNegativeElementSum(array)}");
Console.WriteLine($"Positive elements sum = {GetArrayPositiveElementSum(array)}");
