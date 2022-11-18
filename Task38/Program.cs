// Задача 38: 
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]};");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DiffMaxMin(double[] array)
{
    double maximum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
    }    
    double minimum = maximum;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    }

    double diff = maximum - minimum;
    diff = Math.Round(diff, 1);
    return diff;
}


double[] arr = CreateArrayRndInt(5, 1, 20);
PrintArray(arr);

double result = DiffMaxMin(arr);
Console.WriteLine($"Разница между max и min = {result}");
