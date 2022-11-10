// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


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

static string PrintResult(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber)
    {
        return firstNumber.ToString();
    }
    return(firstNumber + ", " + PrintResult(firstNumber + 1, secondNumber));
}


int firstUserNumber = GetNumberFromUser("N: ", "Error. Try again.");
int secondUserNumber = GetNumberFromUser("M: ", "Error. Try again.");
Console.Write($"N = {firstUserNumber}; M = {secondUserNumber} -> \"");

if (firstUserNumber < secondUserNumber)
{
    Console.Write(PrintResult(firstUserNumber, secondUserNumber));
}
else
{
    Console.Write(PrintResult(secondUserNumber, firstUserNumber));
}

Console.WriteLine("\"");
