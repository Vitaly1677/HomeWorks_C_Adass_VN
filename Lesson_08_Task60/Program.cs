// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,] array3D = CreateArray3DRndInt(4,4,10,99);
PrintMatrix(array3D,"Массив");

int[] CreateArrayUnicInt(int min, int max)
{
    int arrSize = max-min+1;
    int[] arr = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        arr[i] = i+min;
    }
    return arr;
}

int[] MixArrayInt(int[] arr)
{
int arrSize = arr.Length;
Random rnd = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        int j = rnd.Next(0,arrSize);
        int temp = arr[j];
        arr[j] = arr[i];
        arr[i] = temp;
    }
    PrintArray(arr);
    return arr;
}

int[,] CreateArray3DRndInt(int rows, int column, int min, int max)
{
    
    int[] arr = CreateArrayUnicInt(min,max);
    arr = MixArrayInt(arr);

    int[,] arr3D = new int[rows, column];
    int r = 0;
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            arr3D[i, j] = arr[r];
            r++;
        }
    }
    return arr3D;
}

void PrintMatrix(int[,] arr3D, string name)
{
    Console.WriteLine(name);
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            Console.Write($"{arr3D[i, j],4}");
            if (j < arr3D.GetLength(1) - 1) Console.Write(",");

        }
        Console.WriteLine(" ]");
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(i+"_"+arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}