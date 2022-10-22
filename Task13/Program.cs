// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите любое  целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

//int firstDigit = num % 10;
// int secondDigit = number / 10;
int x = number;
if (x > 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int num = number % 10;
    Console.WriteLine($"Третья цифра числа: {num}");
}

else
    Console.WriteLine("Третьей цифры нет");