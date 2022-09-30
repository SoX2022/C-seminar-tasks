Console.Write("Enter first number: ");
string userFirstNumber = Console.ReadLine() ?? "";
Console.Write("Enter second number: ");
string userSecondNumber = Console.ReadLine() ?? "";
int firstNumber = int.Parse(userFirstNumber);
int secondNumber = int.Parse(userSecondNumber);

Console.Clear();
Console.Write("a = " + userFirstNumber + "; b = " + userSecondNumber + " -> max = ");

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}