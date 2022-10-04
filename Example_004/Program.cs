Console.Write("Enter first number: ");
string userFirstNumber = Console.ReadLine() ?? "";
Console.Write("Enter second number: ");
string userSecondNumber = Console.ReadLine() ?? "";
Console.Write("Enter third number: ");
string userThirdNumber = Console.ReadLine() ?? "";
int firstNumber = int.Parse(userFirstNumber);
int secondNumber = int.Parse(userSecondNumber);
int thirdNumber = int.Parse(userThirdNumber);
int max = firstNumber;

Console.Clear();
Console.Write(userFirstNumber + ", " + userSecondNumber + ", " + userThirdNumber + " -> ");

if (secondNumber > max)
{
    max = secondNumber;
}
if (thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine(max);


