// Задача 62: Заполните спирально массив 4 на 4.

int[,] matrix = CreateMatrixSpiralInt(4, 4, 1, 10);
Console.WriteLine("Матрица заполненная по спирали");
PrintMatrix(matrix);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2},");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine("]");
    }
}

int[,] CreateMatrixSpiralInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    int i = 0;
    int j = 0;
    for (int n = 1; n < row * col +1; n++)
    {
        matrix[i, j] = n;
        if (n < 4) j++;
        if (n == 4) i++;
        if (n > 4 && n < 7) i++;
        if (n == 7) j--;
        if (n > 7 && n < 10) j--;
        if (n == 10) i--;
        if (n > 10 && n < 12) i--;
        if (n == 12) j++;
        if (n > 12 && n < 14) j++;
        if (n == 14) i++;
        if (n == 15) j--;
    }
    return matrix;
}

