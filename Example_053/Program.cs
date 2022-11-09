// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



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

static void GetChangedArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}


Console.Clear();
int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
int minRandomValue = new Random().Next(-9, 0);
int maxRansomValue = new Random().Next(0, 10);
int[,] array = GetArray(row, column, minRandomValue, maxRansomValue);

Console.Clear();

PrintArray(array);

Console.WriteLine();

GetChangedArray(array);
PrintArray(array);
