// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


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

static double PrintResult(int firstNumber, int secondNumber, int result)
{
    if (secondNumber == 1)
    {
        return result;
    }
    result *= firstNumber;
    return (PrintResult(firstNumber, secondNumber - 1, result));
}


int firstUserNumber = GetNumberFromUser("A: ", "Error. Try again.");
int secondUserNumber = GetNumberFromUser("B: ", "Error. Try again.");
int result = firstUserNumber;
Console.Write($"N = {firstUserNumber}; M = {secondUserNumber} -> ");

if (secondUserNumber == 0)
    Console.WriteLine(1);
else
{
    double powResult = PrintResult(firstUserNumber, Math.Abs(secondUserNumber), result);

    if (secondUserNumber < 0)
    {
        powResult = 1 / powResult;
        Console.WriteLine(powResult);
    }
    else
        Console.WriteLine(powResult);
}
