// Напишите программу, котрая на вход принимает число (N)
// на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{int count = 2;

while (count <= N && count % 2 == 0)
{
    Console.WriteLine($"{count} ");
    count++;
};
};