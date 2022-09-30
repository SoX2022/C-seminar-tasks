Console.Write("Введите номер дня недели: ");
string day = Console.ReadLine() ?? "";
int dayNumber = int.Parse(day);

Console.Clear();
Console.Write(day + " -> ");

if (dayNumber - 7 * (dayNumber / 7) == 1)
{
    Console.WriteLine("Понедельник");
}
else
{
    if (dayNumber - 7 * (dayNumber / 7) == 2)
    {
        Console.WriteLine("Вторник");
    }
    else
    {
        if (dayNumber - 7 * (dayNumber / 7) == 3)
        {
            Console.WriteLine("Среда");
        }
        else
        {
            if (dayNumber - 7 * (dayNumber / 7) == 4)
            {
                Console.WriteLine("Четверг");
            }
            else
            {
                if (dayNumber - 7 * (dayNumber / 7) == 5)
                {
                    Console.WriteLine("Пятница");
                }
                else
                {
                    if (dayNumber - 7 * (dayNumber / 7) == 6)
                    {
                        Console.WriteLine("Суббота");
                    }
                    else
                    {
                        if (dayNumber - 7 * (dayNumber / 7) == 7)
                        {
                            Console.WriteLine("Воскресенье");
                        }
                    }
                }
            }
        }
    }
}
