// Задача 52:
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} |");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine(" |");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();

Console.WriteLine($"Среднее арифмитическое {array2D.GetLength(1)} столбцов");
for (int j = 0; j < array2D.GetLength(1); j++)
{
    Console.Write("|");
    double sum = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        sum += array2D[i, j];
    }
    double result = sum / array2D.GetLength(0);
    result = Math.Round(result, 1);
    Console.Write($"{result, 5} ");
}
Console.Write("|");