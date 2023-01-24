// Задача 57: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Создаем и печатаем двумерный массив
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



int[] NewArray(int[,] matrix)
{
    int count = 0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count ++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void CountElements(int[] array)
{
    int count = 1;
    int elem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (elem == array[i]) count ++;
        else
        {
            Console.WriteLine($"элементов {elem} -> {count}");
            elem = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"элементов {elem} -> {count}");
    
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] newArray = NewArray(array2D);
Array.Sort(newArray);
PrintArray(newArray);
Console.WriteLine();
CountElements(newArray);