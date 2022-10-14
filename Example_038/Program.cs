//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76
//
//PS. чтобы в выводе вещественные значения не были очень длинными, округлил b[ до 2-х знаков


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

static double[] RandomArray(int arrayLength, int minValue, int maxValue)
{
    double[] randomArray = new double[arrayLength];

    for (int index = 0; index < arrayLength; index++)
    {
        randomArray[index] = new Random().Next(minValue+1, maxValue) + Math.Round(new Random().NextDouble(), 2);
    }

    return randomArray;
}

static double MinValueDetecter(double[] array)
{
    double min = array[0];

    foreach (double element in array)
        if (element < min)
            min = element;
    return min;
}

static double MaxValueDetecter(double[] array)
{
    double max = array[0];

    foreach (double element in array)
        if (element > max)
            max = element;
    return max;
}

static void PrintArray(double[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]} ");
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

double[] array = RandomArray(length, min, max);
double minValue = MinValueDetecter(array);
double maxValue = MaxValueDetecter(array);

Console.Clear();
PrintArray(array);
Console.WriteLine($" -> {maxValue - minValue}");


/*
Почему иногда разница между макс и мин такая, хотя все элементы массива округлялись до 2-х знаков?

[18,98 3,51 5,16 3,2 12,71 8,14] -> 15,780000000000001
18,98
3,2
*/