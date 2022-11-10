// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


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

static string PrintResult(int number, int sum)
{
    if (number == 0)
    {
        return sum.ToString();
    }
    sum += number % 10;
    number /= 10;
    return (PrintResult(number, sum));
}


int userNumber = GetNumberFromUser("Enter your number: ", "Error. Try again.");
int result = 0;
Console.Write($"{userNumber} -> ");
Console.WriteLine(PrintResult(userNumber, result));
