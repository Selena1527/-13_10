// Напишите программу, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());
// string quater = Console.ReadLine();

// МЕТОД
// string Qurter(string quaterXY)
string Qurter(int quaterXY)
{
              // "1"
    if (quaterXY==1) return "xc > 0 и yc > 0";
    if (quaterXY==2) return "xc < 0 и yc > 0";
    if (quaterXY==3) return "xc < 0 и yc < 0";
    if (quaterXY==4) return "xc > 0 и yc < 0";
    return "Введен некорректный номер четверти";
}

string xy = Qurter(quater);
Console.Write($"Диапозон координат для четверти {quater}: ");
Console.WriteLine(xy);