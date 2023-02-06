// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите первое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN > 0)
{
    Console.Write("N = " + numberN + " -> ");
    NaturalNumbersRange(numberN);
    Console.WriteLine("");
}
else Console.WriteLine("Число должно быть больше 0");

void NaturalNumbersRange(int num)
{
    if (num == 1) Console.Write("1");
    else
    {
        NaturalNumbersRange(num - 1);
        Console.Write(", ");
        Console.Write($"{num}");
    }
}