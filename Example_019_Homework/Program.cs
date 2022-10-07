//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да


static int EnterUserNumber()
{
    int userNumber;
    while (true)
    {
        Console.Write("Enter your number: ");
        if (int.TryParse(Console.ReadLine() ?? "", out userNumber) && Math.Abs(userNumber) / 10000 > 0 && userNumber / 100000 == 0)
            break;
        else
            Console.WriteLine("Invalid value.");
    }
    return userNumber;
}

static void FiveDigitNumberPalindromeDetecter(int userNumber)
{
    if (userNumber / 10000 == userNumber % 10 && userNumber / 1000 % 10 == userNumber % 100 / 10)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}

Console.Clear();
int number = EnterUserNumber();
Console.Clear();
Console.Write($"{number} -> ");
FiveDigitNumberPalindromeDetecter(number);
