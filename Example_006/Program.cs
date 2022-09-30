Console.Write("Enter your number: ");
string userNumber = Console.ReadLine() ?? "";
int number = int.Parse(userNumber);

Console.Clear();
Console.Write(userNumber + " -> ");
if (number % 2 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}