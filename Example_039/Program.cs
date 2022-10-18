//Напишите программу, которая перевернет одномерный массив.
//[12345] -> [54321]
//[6726] -> [6276]


static int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

static int[] ReversArray1(int[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}

static void ReversArray2(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int k = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = k;
    }
}


Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray = ReversArray1(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray2(array);
Console.WriteLine(String.Join(" ", array));
