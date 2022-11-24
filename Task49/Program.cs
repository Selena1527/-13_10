// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив     Новый массив будет выглядеть
//  выглядел вот так:              вот так:
// 1 4 7 2                         1 4 49 2
// 5 9 2 3                         5 81 2 9
// 8 4 2 4                         64 4 4 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0, 4} ", array[i, j]);
        Console.WriteLine(" |");
    }
    Console.WriteLine();
}

int[,] FindSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] *= array[i, j];
        }
    }
    return array;
}

int[,] array2D = CreateMatrixRndInt(3, 5, -10, 10);
PrintMatrix(array2D);
array2D = FindSquare(array2D);
PrintMatrix(array2D);