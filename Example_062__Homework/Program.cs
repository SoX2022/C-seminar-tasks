// Заполните спирально массив 4 на 4.


static int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    int i = 0;
    int j = 0;
    array[i, j] = 1;

    while (true)
    {
        while (j + 1 < column && array[i, j + 1] == 0)
        {
            array[i, j + 1] = array[i, j] + 1;
            j += 1;
        }
        while (i + 1 < row && array[i + 1, j] == 0)
        {
            array[i + 1, j] = array[i, j] + 1;
            i += 1;
        }
        while (j > 0 && array[i, j - 1] == 0)
        {
            array[i, j - 1] = array[i, j] + 1;
            j -= 1;
        }
        while (i > 0 && array[i - 1, j] == 0)
        {
            array[i - 1, j] = array[i, j] + 1;
            i -= 1;
        }
        if (array[i, j] == row * column)
            break;
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
int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
int[,] array = FillArray(row, column);
PrintArray(array);
