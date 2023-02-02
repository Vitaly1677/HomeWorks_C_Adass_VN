// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Матрицу A можно умножить на матрицу B только в том случае, 
// если число столбцов матрицы A равняется числу строк матрицы B.
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

Begin:
Console.WriteLine("Введите данные для умножения матриц.");
int rowMatrixA = ReadMatrixParam("Матрица А, кол-во строк: ");
int colMatrixA = ReadMatrixParam("Матрица А, кол-во столбцов: ");
int rowMatrixB = ReadMatrixParam("Матрица B, кол-во строк: ");
int colMatrixB = ReadMatrixParam("Матрица B, кол-во столбцов: ");
if (colMatrixA != rowMatrixB)
{
    Console.WriteLine("Ошибка. Кол-во столб. матрицы А не равно стр. матрицы В, повторите ввод, для выхода Ctrl C");
    goto Begin;
}

int[,] matrixA = CreateMatrixRndInt(rowMatrixA, colMatrixA, 1, 9);
int[,] matrixB = CreateMatrixRndInt(rowMatrixB, colMatrixB, 1, 9);
int[,] matrixC = MultipliMatrix(matrixA, matrixB);

PrintMatrix(matrixA, "Матрица А");
PrintMatrix(matrixB, "Матрица B");
PrintMatrix(matrixC, "Матрица C (результат умножения Матрицы A на Матрицу В)");

int ReadMatrixParam(string name)
{
    int num = 0;
    do
    {
        num = (ReadIntNumder(name));
        if (num <= 0) Console.WriteLine("Введено число <= 0, повторите ввод, для выхода Ctr C");
    }
    while (num <= 0);
    return num;
}

int ReadIntNumder(string name)
{
    Console.Write(name);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] MultipliMatrix(int[,] a, int[,] b)
{
    int nCount = a.GetLength(1);
    int iCount = a.GetLength(0);
    int jCount = b.GetLength(1);
    int[,] c = new int[iCount, jCount];
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

void PrintMatrix(int[,] matrix, string name)
{
    Console.WriteLine(name);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
            if (j < matrix.GetLength(1) - 1) Console.Write(",");

        }
        Console.WriteLine(" ]");
    }
}