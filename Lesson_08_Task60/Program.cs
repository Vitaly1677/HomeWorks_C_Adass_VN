// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,,] array3D = CreateArray3DRndInt(3, 3, 3, 10, 99);
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
int[,,] CreateArray3DRndInt(int rows, int column, int dim, int min, int max)
{

    int[] arr = CreateArrayUnicInt(min, max);
    arr = MixArrayInt(arr);

    int[,,] arr3D = new int[rows, column, dim];
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

