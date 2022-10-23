// Напишите программу, которая принимает на вход
// координаты точки (X и Y),
// причем X не равно 0 и Y не равно 0
// выдает номер четверти плоскости,
// в котором находится эта точка. 

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// МЕТОД

int Qurter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quater = Qurter(x, y);
string result = quater > 0
                ? $"Указанные координаты соответствуют четверти -> {quater}"
                : "Введены некорректные координаты.";
Console.WriteLine(result);