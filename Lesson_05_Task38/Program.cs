// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(4, 100);
PrintArrayDouble(array);

double diffMinMaxinArray = DiffMinMaxInArray(array);

Console.Write($"Разница между макс. и мин. элементами массива = ");
Console.WriteLine("{0,8:N1}",diffMinMaxinArray);

double DiffMinMaxInArray(double[] arr)
{ 
    double max = arr[0];
    double min = arr[0];
   
    for (int i = 1; i < arr.Length; i++)
    {

        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];

    }
    return max - min;
}

double[] CreateArrayRndDouble(int size, int multiplier)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*multiplier;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) 
        {
        Console.Write("{0,8:N1}", arr[i]);
        Console.Write("; ");
        }
        else Console.Write("{0,8:N1}", arr[i]);
    }
    Console.WriteLine("]");
}