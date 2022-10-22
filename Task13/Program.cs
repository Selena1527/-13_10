// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите любое  целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = num % 10;

int secondDigit = num / 10;
if (num > 999)
    {
        while (secondDigit > 999)
{
    secondDigit = secondDigit / 10;
}
    }    
if (num > 99) Console.WriteLine($"Третья цифра числа: {firstDigit}");

else 
Console.WriteLine("Третьей цифры нет");