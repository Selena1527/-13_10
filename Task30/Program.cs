// Напишите программу, которая выводит массив из 8 эллементов
// заполненный нулями и единицами в случайном порядке

// [1, 0, 1, 1, 0, 1, 0, 0]

Console.WriteLine("Введите колличество эллементов: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] NameArray(int number)
{

    int[] array = new int[number];  // 0 1 2 3 4 5 6 7
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+",");
    }
}
int[] nameArray = NameArray(num);
PrintArray(nameArray);