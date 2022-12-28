// Задача 19
// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число, для проверки, является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());
// int number = 12022;
int numberLenght = number;
int count = 5;
while (count > 0)
{
    numberLenght = numberLenght / 10;
    count--;
}
// Console.WriteLine($"ЧислоМое = {numberLenght}");
if (numberLenght == 0)
{
Console.Write ($"{number} -> ");
Console.WriteLine(PolyTest(number) ? "да":"нет");
}
else
{
    Console.WriteLine("Число не 5-и значное.");
}

bool PolyTest(int num)
{
int count = 0;
int oldNum = num;
int polyNum = 0;
   
    while (num > 0)
    {
        polyNum = polyNum * 10 + num % 10;
        num = num / 10;
    }
return polyNum == oldNum;
}
