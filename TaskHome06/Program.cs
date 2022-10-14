// Напишите программу, которая принимает на вход три числа
// выдает максимальное из этих чисел
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите три числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"max = {num1}");
}
if (num2 >num1 && num2 > num3)
{
    Console.WriteLine($"max = {num2}");
}
if (num3 > num1 && num3 > num2)
{
    Console.WriteLine($"max = {num3}");
}    