//Наришите программу, которая принимает на вход число и выдает кол-во цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

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

static int NumbersCount(int number)
{
    int count = 0;
    while (number > 10)
    {
        count++;
        number = number / 10;
    }
    count++;
    return count;
}


Console.Clear();
int number = GetNumberFromUser("Enter your number: ", "Error");
int result = NumbersCount(Math.Abs(number));
Console.WriteLine($"{number} -> {result}");
