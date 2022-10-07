//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A(3,6); B(2,1) -> 5,09
//A(7,-5); B(1,-1) -> 7,21



static int Koords(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse(int ax, int ay, int bx, int by)
{
    double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    return result;
}



int ax, ay, bx, by;

ax = Koords("Введите координату x первого числа: ");
ay = Koords("Введите координату y первого числа: ");
bx = Koords("Введите координату x второго числа: ");
by = Koords("Введите координату y второго числа: ");
//Console.WriteLine($"{ax}, {ay}, {bx}, {by}");

double distanse = Distanse(ax, ay, bx, by);
Console.WriteLine(distanse);

