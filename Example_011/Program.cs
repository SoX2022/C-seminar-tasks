int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine($"Ошибка ввода!");
    }
    return number;
}

int firstNumber = EnterNumber();
int secondNumber = EnterNumber();

//Console.Write("Введите первое число: ");
//int firstNumber = int.Parse(Console.ReadLine() ?? "");
//Console.Write("Введите второе число: ");
//int secondNumber = int.Parse(Console.ReadLine() ?? "");

Console.Clear();
Console.Write($"{firstNumber}, {secondNumber} -> ");

if (firstNumber % secondNumber == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine($"не кратно, остаток {firstNumber % secondNumber}");
