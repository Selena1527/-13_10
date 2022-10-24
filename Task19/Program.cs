﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int A1 = n / 10000;
int A2 = n % 10;
int B1 = (n / 1000) % 10;
int B2 = (n % 10) % 10;

bool Revers(int N, int A1, int A2, int B1, int B2)
{
    int a1 = N / 10000;
    int a2 = N % 10;
    int b1 = (N / 1000) % 10;
    int b2 = (N /10) % 10;
    if(a1 == a2 && b1 == b2) return true;
    return false;
}

bool result = Revers(n, A1, A2, B1, B2);
if (result)
{
    Console.WriteLine("Да, является палиндромом.");
}
else
{
    Console.WriteLine("Нет, не является палиндромом.");
}
