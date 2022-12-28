// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8 
// 918 -> 1

Console.Write("Ведите 3-х значное число для отображения 2-ой цифры: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;

if (number > 99 && number < 1000)
{
    Console.WriteLine($"{number}  ->  {SecondNumberWrite(number)}");
}
else
{
    Console.WriteLine("Введено не 3-х значное число.");
}

int SecondNumberWrite(int num)
{
    return num / 10 % 10;
}