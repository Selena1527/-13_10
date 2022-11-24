// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int CalsSummDiagonal(int[,] array)
{
    int sum = 0;
    int diag = 0;
    if (array.GetLength(0) > array.GetLength(1))
        diag = array.GetLength(1);
    else diag = array.GetLength(0);
    for (int i = 0; i < diag; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(3, 5, -10, 10);
PrintMatrix(array2D);
int calsSummDiagonal = CalsSummDiagonal(array2D);
Console.WriteLine($"Сумма элементов на главной диагонале = {calsSummDiagonal}");