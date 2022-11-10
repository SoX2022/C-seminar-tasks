// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

static string PrintResult(int number)
{
    if (number == 1)
    {
        return number.ToString();
    }
    return (number + ", " + PrintResult(number - 1));
}


int userNumber = GetNumberFromUser("N: ", "Error. Try again.");

Console.Write($"N = {userNumber} -> \"");
Console.Write(PrintResult(userNumber));
Console.WriteLine("\"");
