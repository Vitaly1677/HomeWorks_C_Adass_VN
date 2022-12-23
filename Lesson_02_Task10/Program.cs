// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8 
// 918 -> 1
begin:
Console.Write("Ведите 3-х значное число для отображения 2-ой цифры: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 999 || number < 100) && (number > -100 || number < -999))
{
    Console.WriteLine("Введено не 3-х значное число, повторите ввод.");
    goto begin;
}
Console.WriteLine($"{number}  ->  {Math.Abs(SecondNumberWrite(number))}");
int SecondNumberWrite(int num)
{
    return num / 10 % 10;
}