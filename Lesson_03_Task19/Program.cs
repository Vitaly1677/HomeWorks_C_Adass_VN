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
if (number / 10000 > 0 && number / 10000 < 10)
{
    Console.Write($"{number} -> ");
    Console.WriteLine(PolyTest(number) ? "да" : "нет");
}
else Console.WriteLine("Число не пятизначное.");

bool PolyTest(int num)
{
    int tempNum = num;
    int invertedNum = 0;
    while (tempNum > 0)
    {
        invertedNum = invertedNum * 10 + tempNum % 10;
        tempNum = tempNum / 10;
    }
    return invertedNum == num;
}
