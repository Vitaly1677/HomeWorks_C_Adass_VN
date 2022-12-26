// Задача 19
// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Begin:
Console.Write("Введите 5-и знач. число, для проверки, является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number < 10000 || number > 99999 ) 
{
    Console.WriteLine("Число не 5-и значное, повторите ввод.");
    goto Begin;
}
Console.Write ($"{number} -> ");
Console.WriteLine(PolyTest(number) ?  "да" : "нет");

bool PolyTest(int num)
{
int numberPoly1 = num / 1000;
int numberPoly2 = num % 10 * 10 + number /10 % 10;
return numberPoly1 == numberPoly2;
}
