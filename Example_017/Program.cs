//Напишите программы, которая принимает на вход координатф точки (X и Y), причем X != 0 и Y != 0, и выдает номер плоскости, в которой находится эта точка.

int x, y;

try
{
    Console.Write("X = ");
    x = int.Parse(Console.ReadLine() ?? "");
    
    Console.Write("Y = ");
    y = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine($"Error : Invalid number. Please try again. {exc.Message}");
    return;
}


//while (true)
//{
//    Console.Write("X = ");
//    if (int.TryParse(Console.ReadLine(), out x))
//        if (x != 0)
//            break;
//        else
//            Console.WriteLine("Error : X can't be equal 0. Please try again.");
//    else
//        Console.WriteLine("Error : Invalid number. Please try again.");
//}
//
//while (true)
//{
//    Console.Write("Y = ");
//    if (int.TryParse(Console.ReadLine(), out y))
//        if (y != 0)
//            break;
//        else
//            Console.WriteLine("Error : Y can't be equal 0. Please try again.");
//    else
//        Console.WriteLine("Error : Invalid number. Please try again.");
//}

if (x > 0 && y > 0)
    Console.WriteLine("1st quarter");
else if (x < 0 && y > 0)
    Console.WriteLine("2nd quarter");
else if (x < 0 && y < 0)
    Console.WriteLine("3rd quarter");
else
    Console.WriteLine("4th quarter");
