int number = new Random().Next(10, 1000);
int number1 = number / 100;
int number3 = number % 10;

Console.WriteLine($"{number} -> {number1}{number3}");
