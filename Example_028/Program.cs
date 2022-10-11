//Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
//4 -> 24
//5 -> 120


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

static int NumbersFact(int number)
{
    int result = 1;
    while (number > 1)
    {
        result *= number;
        number -= 1;
    }
    return result;
}


Console.Clear();
int number = GetNumberFromUser("Enter your number: ", "Error");
int result = NumbersFact(number);
Console.WriteLine($"{number} -> {result}");
