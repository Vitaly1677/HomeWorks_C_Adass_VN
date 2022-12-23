// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8 
// 918 -> 1

Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number}  ->  {SecondNumberWrite(number)}");
int SecondNumberWrite(int num)
{
    return num / 10 - num / 100 * 10;
}