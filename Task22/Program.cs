// Напишите программу, которая принимает на вход число (N)
// выдает таблицу квадратов чисел от 1 до N

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"|{i,4} | {i * i,4}|");
        }
    }
    else Console.WriteLine("Введите положительное число");
}
SquareTable(n);

