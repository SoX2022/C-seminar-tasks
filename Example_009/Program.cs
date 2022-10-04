int number = new Random().Next(10, 100);
int number1 = number / 10;
int number2 = number % 10;

//if (number1 < number2)
//    number1 = number2;
//
//Console.WriteLine($"{number} -> {number1}");

int max = number1;

if (max < number2)
    max = number2;

Console.WriteLine($"{number} -> {max}");
