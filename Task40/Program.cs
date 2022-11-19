// Задача 40: 
// Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите три числа через Enter: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

bool IsExsistTriangle(int n1, int n2, int n3)
{
    bool b = n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2;
    return b;
}

bool isExsistTriangle = IsExsistTriangle(num1, num2, num3);
Console.WriteLine(isExsistTriangle);