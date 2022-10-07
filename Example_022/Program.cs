//Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1, 4.

static void PrintSquares(int N)
{
    for (int i = 1; i < N; i++)
    {
        Console.Write($"{i * i}, ");
    }
}


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{number} -> ");
PrintSquares(number);
Console.WriteLine($"{number * number}.");
