// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8 
// 918 -> 1

Console.Write("Ведите 3-х значное число для отображения 2-ой цифры: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SecondNumberWrite(number) != -1 ? $"{number}  ->  {SecondNumberWrite(number)}" : "Число не трехзначное.");
int SecondNumberWrite(int num)
{
    if (num <= 999 && num >= 100) return num / 10 % 10;
    else return num = -1;
}