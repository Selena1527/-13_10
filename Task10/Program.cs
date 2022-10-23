// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Метод
int SecondDigit(int num)
{
    int Digit = (num / 10) % 10;
    return Digit;
}

int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа равна {secondDigit}");




