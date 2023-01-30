// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
double[] arithmeticMeanCol = CreateArrayArithmeticMeanCol(array2D);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArray(arithmeticMeanCol);

double[] CreateArrayArithmeticMeanCol(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    double num = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            num += matrix[j, i];
        }
        num /= matrix.GetLength(0);
        arr[i] = num;
        num = 0;
    } 
    return arr;
}

void PrintMatrix(int[,] matrix)
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

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    Console.Write("{0,6:N1}", arr[i]);
    }
    Console.WriteLine("");
}