// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число (N) для выдачи таблицы кубов чисел от 1 до N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) TableSquare(number);
else System.Console.WriteLine("Введено не натуральное число.");

void TableSquare(int num)
{
    int count = 1;
    System.Console.WriteLine($"{number} ->");
    while (count <= number)
    {
        Console.WriteLine($"{count} | {Math.Pow(count, 3)}");
        count++;
    }
}