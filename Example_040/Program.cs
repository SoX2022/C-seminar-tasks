//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//каждая сторона треугольника меньше суммы двух других сторон



static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber ) && userNumber > 0;
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

static bool TriangleCheck(int firstLength, int secondLength, int thirdLength)
{
    if (firstLength < secondLength + thirdLength && secondLength < firstLength + thirdLength && thirdLength < firstLength + secondLength)
        return true;
    else
        return false;
}


Console.Clear();
int firstUserLength = GetNumberFromUser("Enter first Length of your triangle : ", "Error. Try again.");
int secondUserLength = GetNumberFromUser("Enter second Length of your triangle : ", "Error. Try again.");
int thirdUserLength = GetNumberFromUser("Enter third Length of your triangle : ", "Error. Try again.");

bool result = TriangleCheck(firstUserLength, secondUserLength, thirdUserLength);

if (result)
    Console.WriteLine("Triangle exist.");
else
    Console.WriteLine("This triangle can't exist.");
