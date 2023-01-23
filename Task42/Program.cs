// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int num)
{
    int result = 0;
    while (num > 0)
    {
        int dig = num % 2;
        result += dig;
        result *= 10;
        num /= 2;
    }
    return result;
}

int ReversNumber(int par)
{
    int result = 0;
    while (par > 9 || par > 0)
    {
        result += par % 10;
        result *= 10;
        par /= 10;
    }
    result += par % 10;
    return result;
}


Console.WriteLine(ReversNumber(ConvertToBin(number)));


// Console.WriteLine("Введите число в десятичной системе: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Binare(int num)
// {
//     string st = "";
//     while (num > 0)
//     {
//         string temp = Convert.ToString(num % 2);
//         st = temp + st;
//         num = num / 2;
//     }

//     int bin = Convert.ToInt32(st);
//     return bin;
// }

// Console.WriteLine($"Число {number} в двоичной системе выглядит {Binare(number)}");

// string BinareRecurcy (int num, string st = "")
// {
//     if (num == 0)
//     {
//         return st;
//     }
//     else return BinareRecurcy(num / 2, st = (num % 2) + st);
// }
