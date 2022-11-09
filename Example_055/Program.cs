// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


static int[,] GetArray(int row, int column, int minRandomValue, int maxRansomValue)
{
    int[,] randomArray = new int[row, column];

    for (int rowIndex = 0; rowIndex < row; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < column; columnIndex++)
        {
            randomArray[rowIndex, columnIndex] = new Random().Next(minRandomValue, maxRansomValue);
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

static bool ArrayCheck(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
        return true;
    return false;
}

static void GetChangedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}


Console.Clear();
int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
// int row = 4;
// int column = 4;
int minRandomValue = new Random().Next(-9, 0);
int maxRansomValue = new Random().Next(0, 10);
int[,] array = GetArray(row, column, minRandomValue, maxRansomValue);

Console.Clear();

PrintArray(array);

Console.WriteLine();

if (ArrayCheck(array))
{
    GetChangedArray(array);
    PrintArray(array);
}
else
    Console.WriteLine("Невозможно транспонировать массив.");
