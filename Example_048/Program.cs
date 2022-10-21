//Задайте двумерный массив размера m на n, каждый элемент в массиве нахдодится по формуле: Amn = m + n.
//Вывелите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5


static int GetNumberFromUser(string message, string errorMessage)
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

static int[,] GetArray(int row, int column)
{
    int[,] array = new int[row, column];

    for (int rowIndex = 0; rowIndex < row; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < column; columnIndex++)
        {
            array[rowIndex, columnIndex] = rowIndex + columnIndex;
        }
    }
    return array;
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

int row = GetNumberFromUser("Enter number of rows are in your array : ", "Error. Try again.");
int column = GetNumberFromUser("EEnter number of columns are in your array : ", "Error. Try again.");

Console.Clear();

int[,] array = GetArray(row, column);
PrintArray(array);
