// Задача 60: Сформируйте трёхмерный массив из 
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Begin:
Console.WriteLine("Введите данные для заполнения трехмерной матрицы неповторяющимися двузначными числами.");
int rowArray3D = ReadMatrixParam("Матрица 3D, строки: ");
int colArray3D = ReadMatrixParam("Матрица 3D, столбцы: ");
int depArray3D = ReadMatrixParam("Матрица 3D, глубина: ");
if (rowArray3D*colArray3D*depArray3D > 90)
{
    Console.WriteLine("Ошибка. Слишком большая матрица, повторите ввод, для выхода Ctrl C");
    Console.WriteLine("");
    goto Begin;
}

int[,,] array3D = CreateArray3DRndInt(rowArray3D, colArray3D, depArray3D, 10, 99);
Console.WriteLine("Tрёхмерный массив из неповторяющихся двузначных чисел");
PrintArray3D(array3D);


int[] CreateArrayUnicInt(int min, int max)
{
    int arrSize = max - min + 1;
    int[] arr = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        arr[i] = i + min;
    }
    return arr;
}
int[] MixArrayInt(int[] arr)
{
    int arrSize = arr.Length;
    Random rnd = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        int j = rnd.Next(0, arrSize);
        int temp = arr[j];
        arr[j] = arr[i];
        arr[i] = temp;
    }
    return arr;
}
int[,,] CreateArray3DRndInt(int rows, int column, int dep, int min, int max)
{

    int[] arr = CreateArrayUnicInt(min, max);
    arr = MixArrayInt(arr);

    int[,,] arr3D = new int[rows, column, dep];
    int r = 0;
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                arr3D[i, j, k] = arr[r];
                r++;
            }

        }
    }
    return arr3D;
}

void PrintArray3D(int[,,] arr3D)
{
    Console.Write("[ ");
    for (int i = 0; i < arr3D.GetLength(2); i++)
    {
        Console.Write("i, j, k,  N");
        if (i < arr3D.GetLength(2) - 1) Console.Write("; ");
    }
Console.WriteLine(" ]");
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            Console.Write("[ ");
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{i}, {j}, {k}, {arr3D[i, j, k]}");
                if (k < arr3D.GetLength(2) - 1) Console.Write("; ");
            }
            Console.WriteLine(" ]");
        }
    }
}
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
