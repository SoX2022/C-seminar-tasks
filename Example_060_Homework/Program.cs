// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


static int[,,] GetArray(int row, int column, int depth)
{
    int[,,] randomArray = new int[row, column, depth];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                while (true)
                {
                    int randomValue = new Random().Next(-99, 100);
                    if (randomValue < -9 || randomValue > 9)
                    {
                        if (ArrayElementDetecter(randomArray, randomValue))
                        {
                            randomArray[i, j, k] = randomValue;
                            break;
                        }
                    }
                }
            }
        }
    }
    return randomArray;
}

static bool ArrayElementDetecter(int[,,] array, int value)
{
    foreach (int element in array)
    {
        if (element == value)
            return false;
    }
    return true;
}

static void PrintResult(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}

Console.Clear();

int i, j, k;

while (true)
{
    i = new Random().Next(1, 10);
    j = new Random().Next(1, 10);
    k = new Random().Next(1,10);
    if (i * j * k < 181)
        break;
}

int[,,] array = GetArray(i, j, k);

Console.Clear();

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine($"Array [ {i} x {j} x {k} ]");
Console.WriteLine();
PrintResult(array);
