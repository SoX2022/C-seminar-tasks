//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


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

static double[,] GetArray(int row, int column, int minRandomValue, int maxRansomValue)
{
    double[,] randomArray = new double[row, column];

    for (int rowIndex = 0; rowIndex < row; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < column; columnIndex++)
        {
            randomArray[rowIndex, columnIndex] = Math.Round(new Random().Next(minRandomValue, maxRansomValue) + new Random().NextDouble(), 1);
        }
    }
    return randomArray;
}

static void PrintArray(double[,] array)
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



Console.Clear();

int row = GetPositiveNumberFromUser("Enter number of rows are in your array : ", "Error. Try again.");

int column = GetPositiveNumberFromUser("EEnter number of columns are in your array : ", "Error. Try again.");

int min = GetAnyNumberFromUser("Enter minimum value for your array : ", "Error. Try again.");
int max = GetAnyNumberFromUser("Enter maximum value for your array ", "Error. Try again.");

Console.Clear();
double[,] array = GetArray(row, column, min, max);
PrintArray(array);
