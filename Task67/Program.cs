// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumElemNamber(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumElemNamber(num / 10);
}
 int sumElemNamber = SumElemNamber(number);
Console.WriteLine($"Сумма цифр числа = {sumElemNamber}");