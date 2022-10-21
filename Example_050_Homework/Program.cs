//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//
//17 -> такого числа в массиве нет



static int GetPositiveNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber) && userNumber > 0;
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

static bool CheckForUserIndexes(int[,] array, int row, int column)
{
    if (row - 1 < array.GetLength(0) && column - 1 < array.GetLength(1))
        return true;
    return false;
}


Console.Clear();
int userRow = GetPositiveNumberFromUser("Enter number of rows are in your array : ", "Error. Try again.");

int userColumn = GetPositiveNumberFromUser("EEnter number of columns are in your array : ", "Error. Try again.");

int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
int minRandomValue = new Random().Next(-9, 0);
int maxRansomValue = new Random().Next(0, 10);
int[,] array = GetArray(row, column, minRandomValue, maxRansomValue);

Console.Clear();
PrintArray(array);

Console.WriteLine();

bool checkResult = CheckForUserIndexes(array, userRow, userColumn);

if (checkResult)
    Console.WriteLine($"Element of array [{userRow},{userColumn}] = {array[userRow - 1, userColumn - 1]}.");
else
    Console.WriteLine($"[{userRow},{userColumn}] -> there is no element in the array.");
