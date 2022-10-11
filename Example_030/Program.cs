//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
//[1,0,1,1,0,1,0,0]


static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber) && userNumber > 0;
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

static void RandomMassive(int maxNumber)
{
    int[] array = new int[maxNumber];
    Console.Write("[");
    for (int index = 0; index < maxNumber - 1; index++)
    {
        array[index] = new Random().Next(0, 2);
        Console.Write($"{array[index]},");
    }
    array[maxNumber - 1] = new Random().Next(0, 2);
    Console.Write($"{array[maxNumber - 1]}]");
}


Console.Clear();
int userNumber = GetNumberFromUser("Enter massive length: ", "Error");
RandomMassive(userNumber);
