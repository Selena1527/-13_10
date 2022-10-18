// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");
int Digit = number / 10;
// Console.WriteLine($"{firstDigit}");
int result = Digit % 10;
Console.WriteLine($"{result}");


