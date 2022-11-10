// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


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

static int Akkerman(int m, int n)
{
    while (m != 0)
    {
        m -= 1;
        if(n == 0)
            n = 1;
        else
            n = Akkerman(m + 1, n - 1);
    }
    return n + 1;
}


int firstUserNumber = GetNumberFromUser("m: ", "Error. Try again.");
int secondUserNumber = GetNumberFromUser("n: ", "Error. Try again.");
int result = Akkerman(firstUserNumber, secondUserNumber);

Console.Write($"m = {firstUserNumber}; n = {secondUserNumber} -> ");
Console.WriteLine(result);
