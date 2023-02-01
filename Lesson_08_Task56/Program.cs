// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);
int[] arraySumNumRowsMatrix = CreateArraySumNumRowsMatrix(matrix);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
Console.WriteLine("");
Console.Write("Сумма элементов строк матрицы :");
PrintArray(arraySumNumRowsMatrix);
int minSumNumRowsMatrix = MinNumArray(arraySumNumRowsMatrix);
Console.WriteLine("Индекс строки с наименьшей суммой элементов = " + minSumNumRowsMatrix);

int MinNumArray(int[] array)
{
    int min = array[0];
    int index =0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) 
        {
        min = array[i];
        index = i;
        }
    }
    return index;
}

int[] CreateArraySumNumRowsMatrix (int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        array[i] = SumNumRowsMatrix(matrix, i);
    }
    return array;
}

int SumNumRowsMatrix(int[,] matrix, int rows)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    sum += matrix[rows, j];
    }
return sum;
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

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine(" ]");
}