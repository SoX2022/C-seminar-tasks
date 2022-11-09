// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// {1,9,9,0,2,8,0,9}

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза


// 1,2,3
// 4,6,1
// 2,1,6

// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


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

static int CountElement(int[,] array, int number)
{
    int count = 0;

    foreach (int element in array)
    {
        if (element == number)
            count += 1;
    }
    return count;
}


Console.Clear();
int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
int minRandomValue = new Random().Next(-9, 0);
int maxRandomValue = new Random().Next(0, 10);
int[,] array = GetArray(row, column, minRandomValue, maxRandomValue);

Console.Clear();

PrintArray(array);

Console.WriteLine();

for (int i = minRandomValue; i < maxRandomValue + 1; i++)
{
    int arrayCountNumber = CountElement(array, i);
    if (arrayCountNumber > 0)
        Console.WriteLine ($"{i} встречается {arrayCountNumber} раз(а).");
}
