//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10


static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber );
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

static void NumberChanger(int number)
{
    int newNumber = 0;
    int temp = 1;

    while (number > 0)
    {
        newNumber += number % 2 * temp;
        temp *= 10;
        number /= 2;
    }

    Console.WriteLine(newNumber);
}

/*
static string NumberChanger(int number)
{
    string FinishNumber = "";

    while (number > 0)
    {
        int temp = number % 2;
        FinishNumber = temp + FinishNumber;
        number /= 2;
    }
    return FinishNumber;
}
*/

Console.Clear();
int userNumber = GetNumberFromUser("Enter your number : ", "Error. Try again.");

Console.Write($"{userNumber} -> ");

if (userNumber < 0)
    Console.Write(1);

NumberChanger(Math.Abs(userNumber));
