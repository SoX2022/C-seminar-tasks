//Напишите цикл, который принимает на вход два числа и возводит первое число в натуральную степень второго числа.
//3, 5 -> 243
//2, 4 -> 16


static int GetUserNumber(string message, string errorMessage)
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

static void ExponentionResult(int firstNumber, int secondNumber)
{
    double result = 1;

    if (secondNumber > 0)
    {
        for (int exponent = 1; exponent <= secondNumber; exponent++)
            result *= firstNumber;
    }
    else if (secondNumber < 0)
    {
        for (int exponent = 1; exponent <= Math.Abs(secondNumber); exponent++)
            result *= firstNumber;
        result = 1 / result;
    }
    Console.WriteLine($"{firstNumber}, {secondNumber} -> {result}");
}


Console.Clear();
int firstUserNumber = GetUserNumber("Enter first number: ", "Please, enter integer.");
int secondUserNumber = GetUserNumber("Enter second number: ", "Please, enter integer.");
ExponentionResult(firstUserNumber, secondUserNumber);
