// Напишите программу, которая на вход принимает два чила
// Выдает, какое число больше, какое меньше
// a = 5, b = 7 -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3

Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    int max = num1;
    Console.WriteLine($"max = {num1}");
}
else Console.WriteLine($"max = {num2}");