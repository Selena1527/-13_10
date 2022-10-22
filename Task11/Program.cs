// Напишите программу, которая выводит случайное трёхзначное число
// удаляет вторую цифру этого числа. 
//  456 -> 46 
// 782 -> 72 
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = (firstDigit * 10) + thirdDigit;

// Console.WriteLine($"Первая и последняя цифра числа {result}");

// МЕТОД

int DelSecondDigit(int num)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    return (firstDigit * 10) + thirdDigit;
}
int result = DelSecondDigit(number);
Console.WriteLine($"Первая и последняя цифра числа {result}");