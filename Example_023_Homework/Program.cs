//Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125.

static void PrintSquares(int N)
{
    for (int i = 1; i < N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
}


int number;


while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine() ?? "", out number) && number > 0)
        break;
    else
        Console.WriteLine("Invalid value. Please, try again.");
}

Console.Clear();
Console.Write($"{number} -> ");
PrintSquares(number);
Console.WriteLine($"{Math.Pow(number, 3)}.");

