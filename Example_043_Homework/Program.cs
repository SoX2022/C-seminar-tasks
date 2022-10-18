//Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1
//y = k2 * x + b2
//значения b1, k1, b2, k2 задаются пользователем.
//
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


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

static double GetXKoordinate(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
{
    double x = (double) (thirdNumber - firstNumber) / (secondNumber- fourthNumber);
    return x;
}

static double GetYKoordinate(int firstNumber, int secondNumber, double xKoordinate)
{
    double y = secondNumber * xKoordinate + firstNumber;
    return y;
}


Console.Clear();
int userNumberB1 = GetNumberFromUser("Enter b1 : ", "Error. Try again.");
int userNumberK1 = GetNumberFromUser("Enter k1 : ", "Error. Try again.");
int userNumberB2 = GetNumberFromUser("Enter b2 : ", "Error. Try again.");
int userNumberK2 = GetNumberFromUser("Enter k2 : ", "Error. Try again.");

double x = GetXKoordinate(userNumberB1, userNumberK1, userNumberB2, userNumberK2);
double y = GetYKoordinate(userNumberB1, userNumberK1, x);

Console.Clear();
Console.Write($"b1 = {userNumberB1}, k1 = {userNumberK1}, b2 = {userNumberB2}, k2 = {userNumberK2} -> ({x};{y})");
