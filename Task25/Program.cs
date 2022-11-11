// Задача 25.
// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В

// 3, 5 ->243
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// int i = Convert.ToInt32(Math.Pow(num1, num2));
// Console.WriteLine($"Число А в степени В равно {i}");

int Power(int number1, int number2)
{
    int pow = num1;
    for (int i = 1; i < number2; i++)
    {
        pow = pow * number1;
    }
    return pow;
}
if (num2 < 0) 
{
    Console.Write("Число отрицательное");
}
else 
{
int power = Power(num1, num2);
Console.WriteLine($"Число А в степени В = {power}");
}