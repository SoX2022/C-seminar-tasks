// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


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

static void MinElementIndex(int[,] array, int[] tempArray)
{
    int minElement = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minElement)
            {
                minElement = array[i, j];
                tempArray[0] = i;
                tempArray[1] = j;
            }
        }
    }
}

static int[,] GetChangedArray(int row, int column, int[,] array, int[] tempArray)
{
    int[,] newArray = new int[row - 1, column - 1];

    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        int arrayRow = i;

        if (i >= tempArray[0])
            arrayRow += 1;

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int arrayColumn = j;

            if (j >= tempArray[1])
                arrayColumn += 1;

            newArray[i, j] = array[arrayRow, arrayColumn];
        }
    }
    return newArray;
}


Console.Clear();
int row = new Random().Next(2, 10);
int column = new Random().Next(2, 10);
int minRandomValue = new Random().Next(-9, 0);
int maxRandomValue = new Random().Next(0, 10);
int[,] array = GetArray(row, column, minRandomValue, maxRandomValue);

Console.Clear();

PrintArray(array);

Console.WriteLine();

int[] tempArray = new int[2];
MinElementIndex(array, tempArray);

int[,] newArray = GetChangedArray(row, column, array, tempArray);

PrintArray(newArray);
