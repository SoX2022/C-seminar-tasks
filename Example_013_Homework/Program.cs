//Напишите программу, которя выводит третью цифру заданного числа или сообщает что третьей цифры нет.
//645 -> 5        78 -> третьей цифры нет        32679 -> 6

int userNumber;

while (true)
{
    Console.Write("Enter your number: ");
    if (int.TryParse(Console.ReadLine(), out userNumber))
        break;
    Console.WriteLine("Error 666: Incorrect value. Please, try again.");
}

Console.Clear();
Console.Write($"{userNumber} -> ");
userNumber = Math.Abs(userNumber);

if (userNumber < 100)
    Console.WriteLine("there is no third number");
else
{
    while (userNumber > 999)
    {
        userNumber = userNumber / 10;
    }
    Console.WriteLine(userNumber % 10);
}
