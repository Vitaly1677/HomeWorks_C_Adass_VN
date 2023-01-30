// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int rowsLottery = 0;
int colLottery = 0;
Console.WriteLine("Для участия в лотерее введите");
rowsLottery = ReadLotteryNum(" Номер строки: ");
colLottery = ReadLotteryNum("Номер столбца: ");
Console.WriteLine("");

int[,] array2D = CreateMatrixRndInt(rndNum(5, 8), rndNum(2, 5), -99, 99);
PrintArray(array2D);
Console.WriteLine("");

Console.Write(rowsLottery + ", " + colLottery + " -> ");
if (rowsLottery < array2D.GetLength(0) && colLottery < array2D.GetLength(1))
{
    Console.WriteLine("Вы выиграли! Выигрыш = " + array2D[rowsLottery, colLottery]);
}
else Console.WriteLine("Вы проиграли, нет такого элемента.");

int ReadLotteryNum(string name)
{
    int num = 0;
    do
    {
        num = (ReadIntNumder(name));
        if (!PositiveNum(num)) Console.WriteLine("Введено число < 0, повторите ввод, для выхода Ctr C");
    }
    while (!PositiveNum(num));
    return num;
}

int[,] CreateMatrixRndInt(int rows, int column, int min, int max)
{
    int[,] matrix = new int[rows, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int ReadIntNumder(string name)
{
    Console.Write(name);
    return Convert.ToInt32(Console.ReadLine());
}

int rndNum(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max + 1);
}

bool PositiveNum(int num)
{
    return num >= 0;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}