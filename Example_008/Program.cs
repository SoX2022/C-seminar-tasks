Console.Write("Enter your number: ");
string userNumber = Console.ReadLine() ?? "";
int number = int.Parse(userNumber);
int temp = 2;

Console.Clear();
Console.Write(userNumber + " -> ");

while (temp < number - 1)
{
    Console.Write(temp + ", ");
        temp += 2;
}
if (temp <= number)
{
    Console.WriteLine(temp);
}
