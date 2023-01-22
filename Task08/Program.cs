// Напишите программу, котрая на вход принимает число (N)
// на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = 2;  
        while (count <= number)
        {
            if (count % 2 < 1)
            {
            Console.Write($"{count} ");
            }
            count++;  //count = count +1    
        }
}
else
{
    Console.WriteLine("Введите положительное число");
}