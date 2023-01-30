// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] array2D = CreateMatrixRndDouble(3, 4, 10);
Console.WriteLine($"m = {array2D.GetLength(0)}, n = {array2D.GetLength(0)}");
PrintArray(array2D);

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,5:N1}", matrix[i, j]);
            if (j < matrix.GetLength(1) - 1) Console.Write(";");
        }
        Console.WriteLine("  ]");
    }
}

double[,] CreateMatrixRndDouble(int rows, int column, int multiplicity)
{
    double[,] matrix = new double[rows, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() - 0.5) * multiplicity, 1);
        }
    }
    return matrix;
}