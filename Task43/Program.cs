// Задача 43. 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9
//  -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] FindPoint (double b11, double k11, double b22, double k22)
{
    double x = (b22 - b11) / (k11 - k22);

    double y = k22 * x + b22;
    x = Math.Round(x, 1);
    y = Math.Round(y, 1);
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;

    return array;
}

void PrintArray(double[] array)
{
    Console.Write("Точка пересечения: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]};");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] findPoint = FindPoint(b1, k1, b2, k2);
// Console.WriteLine($"Пересекаются в точке: {findPoint}");
PrintArray(findPoint);