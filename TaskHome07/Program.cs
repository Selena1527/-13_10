// Напишите программу, которая на вход принимает число
// выдает, является ли число четным
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Да - четное число!");
}
else 
{
    Console.WriteLine("Нет - не четное");
};