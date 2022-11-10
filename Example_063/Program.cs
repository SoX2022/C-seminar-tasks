// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


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

static string PrintResult(int number, int tempNumber)
{
    if (tempNumber == number)
    {
        return tempNumber.ToString();
    }
    return(tempNumber + ", " + PrintResult(number, tempNumber + 1));
}


int userNumber = GetNumberFromUser("N: ", "Error. Try again.");
int temp = 1;
Console.Write($"N = {userNumber} -> \"");
Console.Write(PrintResult(userNumber, temp));
Console.WriteLine("\"");
