//Напигите программу, которая принимает на вход коордтнаты двух точек и находит расстояние между ними в 3D пространстве.
//A(3,6,8); B(2,1,-7) -> 15.84
//A(7,-5,0); B(1,-1,9) -> 11.53


static void Enter3dCoordinates(int[] array)
{
    string[] vector = { "X", "Y", "Z" };
    int lenght = array.Length;
    int index = 0;

    while (index < lenght)
    {
        while (true)
        {
            Console.Write($"{vector[index]} = ");
            if (int.TryParse(Console.ReadLine() ?? "", out array[index]))
                break;
            else
                Console.WriteLine("Invalid value. Please, try again.");
        }
        index++;
    }
}

static void Print3dCoordinates(int[] array, string message)
{
    int lenght = array.Length;
    int index = 0;

    Console.Write($"{message}(");
    while (index < lenght - 1)
    {
        Console.Write($"{array[index]},");
        index++;
    }
    Console.Write($"{array[index]})");
}

static double DistanseCalculator3D(int[] array1, int[] array2)
{
    double distanse = Math.Round(Math.Sqrt(Math.Pow(array2[0] - array1[0], 2) + Math.Pow(array2[1] - array1[1], 2) + Math.Pow(array2[2] - array1[2], 2)), 2);
    return distanse;
}

int[] A = new int[3];
int[] B = new int[3];

Console.Clear();
Console.WriteLine("Enter first coordinates, please.");
Enter3dCoordinates(A);
Console.WriteLine("Enter second coordinates, please.");
Enter3dCoordinates(B);

double distanse = DistanseCalculator3D(A, B);

Console.Clear();
Print3dCoordinates(A, "A");
Console.Write("; ");
Print3dCoordinates(B, "B");
Console.WriteLine($" ->  {distanse}");
