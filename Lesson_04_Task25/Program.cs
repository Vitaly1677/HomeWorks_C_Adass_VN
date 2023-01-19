// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int[] array = new int[2];
int calcExponent = 0;
string calcError = "Число 2 не натуральное.";
Console.WriteLine("Введите 2 числа для возведения 1-го в натуральную степень 2-го.");
FillArray(array);
calcExponent = CalcExponent(array);
Console.WriteLine(calcExponent != -1 ? $"{array[0]}, {array[1]} -> {calcExponent}" : calcError);
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i + 1} = ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int CalcExponent(int[] arr)
{
    if (array[1] <= 0) return -1;
    int exponent = 1;
    for (int i = 0; i < arr[1]; i++)
    {
        exponent *= arr[0];
    }
    return exponent;
}
