// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN > 0)
{
    Console.Write("M = " + numberM + "; N = " + numberN + " -> ");
    Console.WriteLine(NaturalNumbersRangeSum(numberM, numberN));
}
else Console.WriteLine("Число должно быть больше 0");

int NaturalNumbersRangeSum(int numM, int numN)
{
    if (numM == numN) return numM;
    else return numN + NaturalNumbersRangeSum(numM, numN - 1);
}