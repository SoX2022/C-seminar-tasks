//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


static int GetPositiveNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber ) && userNumber > 0;
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
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber );
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

static void GetNewArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row +=2)
    {
        for (int column = 0; column < array.GetLength(1); column +=2)
        {
            array[row, column] *= array[row, column];
        }
    }
}


Console.Clear();

int row = GetPositiveNumberFromUser("Enter number of rows are in your array : ", "Error. Try again.");

int column = GetPositiveNumberFromUser("EEnter number of columns are in your array : ", "Error. Try again.");

int min = GetAnyNumberFromUser("Enter minimum value for your array : ", "Error. Try again.");
int max = GetAnyNumberFromUser("Enter maximum value for your array ", "Error. Try again.");

int[,] array = GetArray(row, column, min, max);
PrintArray(array);

Console.WriteLine();

GetNewArray(array);
PrintArray(array);
