//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да         7 -> да        1 -> нет

int userDayNumber;

while (true)
{
    Console.Write("Enter day number (1-7): ");
    if (int.TryParse(Console.ReadLine(), out userDayNumber))
        if (userDayNumber < 8)
            if (userDayNumber > 0)
                break;
    Console.WriteLine("Error 667: Incorrect day number. Please, try again.");
}

Console.Clear();
Console.Write($"{userDayNumber} -> ");

if (userDayNumber > 5)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
