Console.Write("Введите первое число: ");
string a = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string b = Console.ReadLine() ?? "";
int a1 = int.Parse(a);
int b1 = int.Parse(b);

Console.Clear();
Console.Write("a = "+ a + ", b = " + b + " -> ");
if (a1 == b1*b1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}