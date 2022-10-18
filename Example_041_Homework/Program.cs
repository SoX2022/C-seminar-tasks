//Пользователь вводит с клавиатуры N чисел.
//Посчитайте, сколько чисел больше 0 ввел пользователь.
//
//0,7,8,-2,-2 -> 2
//-1,-7,567,89,223 -> 3


static int[] FillArray(int[] array)
{
    int index = 0;
    Console.WriteLine("Enter array data. To stop enter 'Q'");

    while (true)
    {
        string userArrayData = Console.ReadLine() ?? "";
        if (int.TryParse(userArrayData, out int userData))
        {
            Array.Resize(ref array, index + 1);
            array[index] = userData;
            index++;
        }
        else
        {
            userArrayData = userArrayData.ToLower();
            if (userArrayData == "q")
                return array;
            else
                Console.WriteLine("Error");
        }
    }
}

static int PositiveValueCounter(int[] array)
{
    int result = 0;
    foreach (int element in array)
    {
        if (element > 0)
            result++;
    }
    return result;
}


Console.Clear();
int[] userArray = new int[0];
userArray = FillArray(userArray);
int counter = PositiveValueCounter(userArray);
Console.Clear();
Console.Write(String.Join(",", userArray));
Console.WriteLine($" -> {counter}");
