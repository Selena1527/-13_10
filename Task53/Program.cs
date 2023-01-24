// Задача 53: 
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0, 4} ", matrix[i, j]);
        Console.WriteLine(" |");
    }
    Console.WriteLine();
}
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
void ReplaceRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

int[,] matrix2D = CreateMatrixRndInt(3, 5, -10, 10);
PrintMatrix(matrix2D);

ReplaceRows(matrix2D);
PrintMatrix(matrix2D);
