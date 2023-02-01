// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
Console.WriteLine("");
Console.WriteLine("Упорядоченная матрица:");


PrintMatrix(matrix);

int[,] SortRowsMatrix(int[,] matrix, int rows)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[rows, j] < matrix[rows, j + 1])
            {
                int temp = matrix[rows, j];
                matrix[rows, j] = matrix[rows, j + 1];
                matrix[rows, j + 1] = temp;
            }
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
