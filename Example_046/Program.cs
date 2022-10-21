//Задайте двумерный массив размером MxN, заполненный случайными целыми числами.
//m = 3, n = 4
//1 4 8 19
//5 -2 33 -2
//77 3 8 1


static int GetNumberFromUser(string message, string errorMessage)
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



Console.Clear();

int row, column;

while (true)
{
    row = GetNumberFromUser("Enter number of rows are in your array : ", "Error. Try again.");
    if (row > 0)
        break;
    else Console.WriteLine("Error. Array length must have positive value.");
}

while (true)
{
    column = GetNumberFromUser("EEnter number of columns are in your array : ", "Error. Try again.");
    if (column > 0)
        break;
    else Console.WriteLine("Error. Array length must have positive value.");
}

int min = GetNumberFromUser("Enter minimum value for your array : ", "Error. Try again.");
int max = GetNumberFromUser("Enter maximum value for your array ", "Error. Try again.");

Console.Clear();

int[,] array = GetArray(row, column, min, max);
PrintArray(array);
