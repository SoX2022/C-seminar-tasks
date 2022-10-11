//Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до A.
//4 -> 10 (1+2+3+4=10)
//7 -> 28
//8 -> 36


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

static int GetSumNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num;
        num--;
    }
    return sum;
}


Console.Clear();
int number = GetNumberFromUser("Enter number A: ", "Error");
int sumNumbers = GetSumNumbers(number);
Console.WriteLine($"{number} -> {sumNumbers}");


