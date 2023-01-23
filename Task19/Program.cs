// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());


bool Revers(int num)
{
    int a1 = num / 10000;
    int a2 = num % 10;
    int b1 = (num / 1000) % 10;
    int b2 = (num / 10) % 10;
    if (a1 == a2 && b1 == b2) return true;
    return false;
}

if (n >= 10000 && n <= 99999)
{
    bool result = Revers(n);
    if (result)
    {
        Console.WriteLine("Да, является палиндромом.");
    }
    else
    {
        Console.WriteLine("Нет, не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}