// 7. Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает последнюю цифру этого числа. 
// 456 -> 6 782 -> 2 918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{ 
    int LastDigit = number % 10;  // 456 % 10 = 6 456 / 10 = 45 / 10 = 4 / 10 = 0
    Console.WriteLine($"Последняя цифра числа = {LastDigit}");
}    
else Console.WriteLine("Введите трехзначное число");

