//Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
//453 -> 12
//82 -> 10
//9012 -> 12


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

static void PrintNumbersSum(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.WriteLine(sum);
}


Console.Clear();
int userNumber = GetUserNumber("Enter your number: ", "Please, enter integer.");
Console.Clear();
Console.Write($"{userNumber} -> ");
PrintNumbersSum(Math.Abs(userNumber));
