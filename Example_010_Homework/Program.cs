//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5        782 -> 8        918 -> 1

int number;
string userAnswer;

while (true)
{
    Console.WriteLine("Do you want to use random number?");
    Console.Write("Y/N? ");
    userAnswer = Console.ReadLine() ?? "";
    if (userAnswer.ToLower() == "y")
    {
        int randomPlusMinus;
        while (true)
        {
            randomPlusMinus = new Random().Next(-1, 2);
            if (randomPlusMinus != 0)
                break;
        }
        number = new Random().Next(100, 1000) * randomPlusMinus;
        break;
    }
    else
    {
        if (userAnswer.ToLower() == "n")
        {
            while (true)
            {
                Console.Write("Enter three-digit number: ");
                if (int.TryParse(Console.ReadLine(), out number))
                    if (Math.Abs(number) / 100 > 0)
                        if (number / 1000 == 0)
                            break;
                Console.WriteLine("Error 666: Incorrect value. Please, try again.");
            }
            break;
        }
        else
            Console.WriteLine("Error 666: Incorrect value. Please, try again.");
    }
}

Console.Clear();
Console.WriteLine($"{number} -> {Math.Abs(number) / 10 % 10}");


//int middleNumber = number / 10 % 10;
//Console.WriteLine($"{number} -> {middleNumber}");
//
//В таких случаях лучше вводить дополнительную переменную или производить вычисления в при выводе?
