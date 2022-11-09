// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


static int[,] GetArray(int i, int j)
{
    int row = new Random().Next(1, i + 1);
    int column = new Random().Next(1, j + 1);
    int minRandomValue = new Random().Next(-9, 0);
    int maxRandomValue = new Random().Next(0, 10);
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

static bool ArrayMultiplicationCheck(int[,] firstArray, int[,] secondArray)
{
    if (firstArray.GetLength(1) == secondArray.GetLength(0))
        return true;
    return false;
}

static int[,] GetArrayMultiplication(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return resultArray;
}



Console.Clear();
int maxRows = 3;
int maxColumns = 3;
int[,] firstArray = GetArray(maxRows, maxColumns);
int[,] secondArray = GetArray(maxRows, maxColumns);

PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();

if (ArrayMultiplicationCheck(firstArray, secondArray))
{
    int[,] multiplicationArray = GetArrayMultiplication(firstArray, secondArray);
    PrintArray(multiplicationArray);
}
else
    Console.WriteLine("Can't get product of two arrays.");
