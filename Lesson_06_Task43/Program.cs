// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// 
// Упрощаем уровнение:
// y = k1 * x + b1, y = k2 * x + b2;
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)



double b1 = ReadDoubleNumder("Bведите b1: ");
double k1 = ReadDoubleNumder("Bведите k1: ");
double b2 = ReadDoubleNumder("Bведите b2: ");
double k2 = ReadDoubleNumder("Bведите k2: ");

if (ChkCoincidence(b1, k1, b2, k2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (ChkParralel(k1, k2))
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
    Console.Write("{0,8:N3}", CalcX(b1, k1, b2, k2));
    Console.Write("; ");
    Console.WriteLine("{0,8:N3}", CalcY(b1, k1, b2, k2));
}


bool ChkCoincidence(double b1, double k1, double b2, double k2)
{
    return ((k1 == k2) && (b1 == b2));
}
bool ChkParralel(double k1, double k2)
{
    return (k1 == k2);
}

double CalcX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double CalcY(double b1, double k1, double b2, double k2)
{
    return (k1 * CalcX(b1, k1, b2, k2) + b1);
}

double ReadDoubleNumder(string ParamName)
{
    Console.Write(ParamName);
    return Convert.ToDouble(Console.ReadLine());
}