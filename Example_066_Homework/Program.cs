// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


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

static int PrintResult(int firstNumber, int secondNumber, int result)
{
    if (firstNumber > secondNumber)
    {
        return result;
    }
    result += firstNumber;
    return(PrintResult(firstNumber + 1, secondNumber, result));
}


int firstUserNumber = GetNumberFromUser("M: ", "Error. Try again.");
int secondUserNumber = GetNumberFromUser("N: ", "Error. Try again.");
int result = 0;
Console.Write($"M = {firstUserNumber}; N = {secondUserNumber} -> ");

if (firstUserNumber < secondUserNumber)
    result = PrintResult(firstUserNumber, secondUserNumber, result);
else
    result = PrintResult(secondUserNumber, firstUserNumber, result);

Console.Write(result);
