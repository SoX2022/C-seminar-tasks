//Задайте двумерный массив. Найдите сумму элементов главной диагонали.
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1 + 9 + 2 = 12



static int GetPositiveNumberFromUser(string message, string errorMessage)
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

static int GetAnyNumberFromUser(string message, string errorMessage)
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

static int[,] GetArray(int row, int column, int minRandomValue, int maxRansomValue)
{
    int[,] randomArray = new int[row, column];

    for (int rowIndex = 0; rowIndex < row; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < column; columnIndex++)
        {
            randomArray[rowIndex, columnIndex] = new Random().Next(minRandomValue, maxRansomValue + 1);
        }
    }
    return randomArray;
}

static void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}

static int ElementsSum(int[,] array)
{
    int result = array[0, 0];
    int temp;

    if (array.GetLength(0) < array.GetLength(1))
        temp = array.GetLength(0);
    else
        temp = array.GetLength(1);

    for (int index = 1; index < temp; index++)
    {
        result += array[index, index];
    }

    return result;
}

static void ElementsSumPrint(int[,] array)
{
    int temp;

    if (array.GetLength(0) < array.GetLength(1))
        temp = array.GetLength(0);
    else
        temp = array.GetLength(1);

    for (int index = 0; index < temp - 1; index++)
    {
        Console.Write($"{array[index, index]} + ");
    }
    Console.Write($"{array[temp - 1, temp - 1]} = ");
}



Console.Clear();

int row = GetPositiveNumberFromUser("Enter number of rows are in your array : ", "Error. Try again.");

int column = GetPositiveNumberFromUser("EEnter number of columns are in your array : ", "Error. Try again.");

int min = GetAnyNumberFromUser("Enter minimum value for your array : ", "Error. Try again.");
int max = GetAnyNumberFromUser("Enter maximum value for your array ", "Error. Try again.");

Console.Clear();
int[,] array = GetArray(row, column, min, max);
PrintArray(array);

Console.WriteLine();

int sum = ElementsSum(array);
Console.Write("Сумма элементов главной диагонали: ");
ElementsSumPrint(array);
Console.WriteLine(sum);
