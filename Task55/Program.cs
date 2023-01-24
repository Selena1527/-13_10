// Задача 55: 
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ReplaceRowsOfColums(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

int[,] matrix = CreateMatrixRndInt(5, 4, -10, 10);
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    PrintMatrix(matrix);
    int[,] newArray2D = ReplaceRowsOfColums(matrix);
    PrintMatrix(newArray2D);
}
else Console.WriteLine("Невозможно заменить стоки на столбцы.");

// Второй способ

// int[,] ReplaceRowsOfColums(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i,j];
//             matrix[i,j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
//     return matrix;
// }

// if (matrix.GetLength(0) == matrix.GetLength(1))
// {
//     PrintMatrix(matrix);
//     int[,] newArray2D = ReplaceRowsOfColums(matrix);
//     PrintMatrix(newArray2D);
// }
// else Console.WriteLine("Невозможно заменить стоки на столбцы.");