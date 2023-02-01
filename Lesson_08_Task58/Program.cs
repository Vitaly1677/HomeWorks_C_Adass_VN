// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Матрицу P можно умножить на матрицу K только в том случае, 
// если число столбцов матрицы P равняется числу строк матрицы K.
//Для проверки 1
// int[,] matrixA = new int[,] { { 15, 27 }, { 18, 10 } };
// int[,] matrixB = new int[,] { { 35 }, { 16 } };
// Матрица C
// [  957  ]
// [  790  ]
//Для проверки 2
// int[,] matrixA = new int[,] { { 1, 2 }, { 3, 4 } };
// int[,] matrixB = new int[,] { { 5, 6 }, { 7, 8 } };
// Матрица C
// [   19,   22  ]
// [   43,   50  ]

// int[,] matrixA = CreateMatrixRndInt(2, 2, 1, 9);
// int[,] matrixB = CreateMatrixRndInt(2, 1, 1, 9);
int[,] matrixC = MultipliMatrix(matrixA, matrixB);

Console.WriteLine("Матрица А");
PrintMatrix(matrixA);
Console.WriteLine("Матрица B");
PrintMatrix(matrixB);
Console.WriteLine("Матрица C");
PrintMatrix(matrixC);

int[,] MultipliMatrix(int[,] a, int[,] b)
{
    int nCount = a.GetLength(1);
    int iCount = a.GetLength(0);
    int jCount = b.GetLength(1);
    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
    for (int j = 0; j < jCount; j++)
    {
        for (int i = 0; i < iCount; i++)
        {
            for (int n = 0; n < nCount; n++)
            {
                c[i, j] += a[i, n] * b[n, j];
            }
        }
    }
    return c;
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