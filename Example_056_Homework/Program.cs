// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.



static int[,] GetArray(int row, int column, int minRandomValue, int maxRandomValue)
{
    int[,] randomArray = new int[row, column];

    for (int rowIndex = 0; rowIndex < row; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < column; columnIndex++)
        {
            randomArray[rowIndex, columnIndex] = new Random().Next(minRandomValue, maxRandomValue);
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

static int[] GetMinSumAndRow(int[,] array)
{
    int[] result = new int[2];
    result[1] = array[0, 0];

    for (int j = 1; j < array.GetLength(1); j++)
    {
        result[1] += array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        if (sum < result[1])
        {
            result[1] = sum;
            result[0] = i + 1;
        }
    }
    return result;
}



Console.Clear();
int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
int minRandomValue = new Random().Next(-9, 0);
int maxRandomValue = new Random().Next(0, 10);
int[,] array = GetArray(row, column, minRandomValue, maxRandomValue);
int[] resultArray = GetMinSumAndRow(array);

Console.Clear();

PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Row number {resultArray[0]} contains the minimum sum of elements ({resultArray[1]}).");
