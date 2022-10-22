// Напишите программу, которая принимает
// на вход цифру, обозначающую день недели,
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// 15 -> не корректно

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Day(int num)
{
    if (num == 6 || num == 7) return true;
    return false;
}

if (number > 0 && number < 8)
{
    bool result = Day(number);
    if (result) Console.WriteLine("Да - выходной день");
    else Console.WriteLine("Нет - будний день");
}
else Console.WriteLine("Данное число не соответсвует дням недели");