Console.Write("Введите номер дня недели: ");
string day = Console.ReadLine() ?? "";
int dayNumber = int.Parse(day);

Console.Clear();
Console.Write(day + " -> ");

if (dayNumber - 7 * (dayNumber / 7) == 1)
{
    Console.WriteLine("Понедельник");
}
if (dayNumber - 7 * (dayNumber / 7) == 2)
{
    Console.WriteLine("Вторник");
}
if (dayNumber - 7 * (dayNumber / 7) == 3)
{
    Console.WriteLine("Среда");
}
if (dayNumber - 7 * (dayNumber / 7) == 4)
{
    Console.WriteLine("Четверг");
}
if (dayNumber - 7 * (dayNumber / 7) == 5)
{
    Console.WriteLine("Пятница");
}
if (dayNumber - 7 * (dayNumber / 7) == 6)
{
    Console.WriteLine("Суббота");
}
if (dayNumber - 7 * (dayNumber / 7) == 7)
{
    Console.WriteLine("Воскресенье");
}
